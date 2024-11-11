using LiftSimGame.Database;
using LiftSimGame.Enums;
using LiftSimGame.Managers;
using LiftSimulator;
using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftSimGame
{
    public partial class MainScreen : Form
    {

        private LiftState liftState = LiftState.Idle;
        private PlayerState playerState = PlayerState.Standing;

        private const int PLAYER_SPEED = 6;
        private const int LIFT_SPEED = 13;
        private const int DOOR_SPEED = 2;
        private const int MAX_FLOORS = 2;
        private const int MIN_FLOORS = 1;

        private int soundTrigger = 1; 

        private int currentFloor = 1;
        private bool isDoorOpen = false;
        private bool isPlayerNearLift = false;
        private bool isPlayerInLift = false;
        private bool isDoorMoving = false;

        private bool isLogsWindowOpen = false;

        private Image standingImg = Image.FromFile("assets\\Char_Idle.png");
        private Image runningGif = Image.FromFile("assets\\gifmaker_me.gif");
        private Image upArrowGif = Image.FromFile("assets\\simple_up.png");
        private Image downArrowGif = Image.FromFile("assets\\simple_down.png");

        protected LiftSimDatabase db;
        private EventLogger logger = new();
        AudioManager manager = new AudioManager();

        public MainScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
            db = new LiftSimDatabase();

            logsTable.ColumnCount = 4;
            logsTable.Columns[0].Name = "ID";
            logsTable.Columns[1].Name = "Event";
            logsTable.Columns[2].Name = "Timestamp";
            logsTable.Columns[3].Name = "Floor";

            logsTable.Columns[0].Width = 50;
            logsTable.Columns[3].Width = 80;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            playerBox.BackgroundImageLayout = ImageLayout.Stretch;
            elevator_door.Location = new Point(2139, 1210);
            elevator.Location = new Point(2121, 1130);

            elevator_door.Anchor = AnchorStyles.Bottom;
            elevator.Anchor = AnchorStyles.Bottom;

            playerBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerBox.Location = new Point(1200, 1369);

            List<EventData> logs = db.ReadEvents();
            foreach (EventData log in logs)
            {
                logsTable.Rows.Add(log.EventId, log.EventType, log.EventTimestamp, log.Floor);
            }
            logsTable.Sort(logsTable.Columns[0], System.ComponentModel.ListSortDirection.Descending);

            logsWindow.Hide();
        }

        private void playerTimer_Tick(object sender, EventArgs e)
        {
            if (liftState != LiftState.Idle && isPlayerInLift) return;

            UpdatePlayerMovement();
        }

        private void UpdatePlayerMovement()
        {
            if (playerState == PlayerState.RunningLeft) HandleLeftMovement();

            else if (playerState == PlayerState.RunningRight) HandleRightMovement();

            else
            {
                playerState = PlayerState.Standing;
                playerBox.BackgroundImage = standingImg;
            }
        }

        private void HandleLeftMovement()
        {
            if (isDoorOpen && !isPlayerNearLift) close_door_timer.Start();
            if (playerBox.Location.X - left_boundary.Location.X < 100) return;

            playerBox.Left -= PLAYER_SPEED;
            playerBox.BackgroundImage = runningGif;
        }

        private void HandleRightMovement()
        {
            if (right_boundary.Location.X - playerBox.Location.X < 240) return;

            if (isDoorMoving && isPlayerNearLift)
            {
                return;
            }

            if (liftState != LiftState.Idle && isPlayerNearLift)
            {
                return;
            }

            if (!isDoorMoving && isDoorOpen && !isPlayerNearLift && liftState == LiftState.Idle)
            {
                close_door_timer.Start();
            }

            if (!isDoorOpen && isPlayerNearLift && liftState == LiftState.Idle)
            {
                open_door_timer.Start();
                return;
            }

            playerBox.Left += PLAYER_SPEED;
            playerBox.BackgroundImage = runningGif;
        }


        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) playerState = PlayerState.RunningLeft;

            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) playerState = PlayerState.RunningRight;

        }

        private void MainScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) playerState = PlayerState.Standing;

            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) playerState = PlayerState.Standing;

        }

        private void open_door_timer_Tick(object sender, EventArgs e)
        {
            int targetOpenYPosition = elevator.Location.Y - 200;
            if (soundTrigger == 1)
            {
                manager.PlayElevatorDoorSound();
                logger.LogEvent("Opening Lift Door", currentFloor, logsTable);
                soundTrigger++;
            }

            if (elevator_door.Location.Y < targetOpenYPosition)
            {
                soundTrigger = 1;
                open_door_timer.Stop();
                logger.LogEvent("Lift Door Opened", currentFloor, logsTable);
                open_button.BackColor = Color.FromArgb(219, 216, 219);
                isDoorOpen = true;
                isDoorMoving = false;
            }
            else
            {
                isDoorMoving = true;
                open_button.BackColor = Color.LightSalmon;
                elevator_door.Location = new Point(elevator_door.Location.X, elevator_door.Location.Y - DOOR_SPEED);
            }
        }

        private void player_in_lift_timer_Tick(object sender, EventArgs e)
        {
            isPlayerInLift = playerBox.Location.X > elevator_door.Location.X &&
                            playerBox.Location.X < elevator_door.Location.X + elevator_door.Width;
        }

        private void player_near_lift_timer_Tick(object sender, EventArgs e)
        {
            const int proximity_threshold = 300;
            if (elevator.Location.X - playerBox.Location.X < proximity_threshold)
            {
                isPlayerNearLift = true;
                player_in_lift_timer.Start();
            }
            else
            {
                isPlayerNearLift = false;
                player_in_lift_timer.Stop();
            }
        }

        private void close_door_timer_Tick(object sender, EventArgs e)
        {
            int targetCloseYPosition = elevator.Location.Y + 70;

            if (soundTrigger == 1)
            {
                manager.PlayElevatorDoorSound();
                logger.LogEvent("Closing Lift Door", currentFloor, logsTable);
                soundTrigger++;
            }

            if (elevator_door.Location.Y > targetCloseYPosition)
            {
                soundTrigger = 1;
                close_door_timer.Stop();
                logger.LogEvent("Lift Door Closed", currentFloor, logsTable);
                close_button.BackColor = Color.FromArgb(219, 216, 219);
                isDoorOpen = false;
                isDoorMoving = false;
            }
            else
            {
                isDoorMoving = true;
                close_button.BackColor = Color.LightSalmon;
                elevator_door.Location = new Point(elevator_door.Location.X, elevator_door.Location.Y + DOOR_SPEED);
            }
        }

        private async void up_button_Click(object sender, EventArgs e)
        {
            if (liftState != LiftState.Idle || currentFloor == MAX_FLOORS || isDoorMoving) return;

            if (isDoorOpen)
            {
                close_door_timer.Start();
                await WaitForDoorToClose();
            }
            logger.LogEvent("Lift Moving Up", currentFloor, logsTable);
            liftState = LiftState.MovingUp;
            manager.PlayLiftMovingSound();
            move_up_timer.Start();
        }

        private async Task WaitForDoorToClose()
        {
            while (isDoorOpen) await Task.Delay(100);

        }

        private async void down_button_Click(object sender, EventArgs e)
        {
            if (liftState != LiftState.Idle || currentFloor == MIN_FLOORS || isDoorMoving) return;

            if (isDoorOpen)
            {
                close_door_timer.Start();
                await WaitForDoorToClose();
            }
            logger.LogEvent("Lift Moving Down", currentFloor, logsTable);
            liftState = LiftState.MovingDown;
            manager.PlayLiftMovingSound();
            move_down_timer.Start();
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (liftState == LiftState.Idle && !isDoorOpen && !isDoorMoving)
            {
                open_door_timer.Start();
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if (liftState == LiftState.Idle && isDoorOpen && !isDoorMoving)
            {
                close_door_timer.Start();
            }
        }

        private void move_up_timer_Tick(object sender, EventArgs e)
        {
            if (currentFloor == MAX_FLOORS)
            {
                move_up_timer.Stop();
                liftState = LiftState.Idle;
                return;
            }

            int targetYPosition = 230;

            if (elevator.Location.Y <= targetYPosition)
            {
                isDoorMoving = true;
                move_up_timer.Stop();
                liftState = LiftState.Idle;
                update_floor_level(true);
                isDoorMoving = true;
                up_button.BackColor = Color.FromArgb(219, 216, 219);
                open_door_timer.Start();
                logger.LogEvent("Lift Arrived at Floor", currentFloor, logsTable);
            }
            else
            {
                liftState = LiftState.MovingUp;
                up_button.BackColor = Color.LightSalmon;
                MoveLift(-LIFT_SPEED);
            }

        }

        private void move_down_timer_Tick(object sender, EventArgs e)
        {
            if (currentFloor == MIN_FLOORS)
            {
                move_down_timer.Stop();
                liftState = LiftState.Idle;
                return;
            }

            int targetYPosition = 1120;

            if (elevator.Location.Y >= targetYPosition)
            {
                isDoorMoving = true;
                move_down_timer.Stop();
                liftState = LiftState.Idle;
                update_floor_level(false);
                isDoorMoving = true;
                down_button.BackColor = Color.FromArgb(219, 216, 219);
                open_door_timer.Start();
                logger.LogEvent("Lift Arrived at Floor", currentFloor, logsTable);
            }
            else
            {
                liftState = LiftState.MovingDown;
                down_button.BackColor = Color.LightSalmon;
                MoveLift(LIFT_SPEED);
            }

        }

        private void MoveLift(int speed)
        {
            if (isPlayerInLift)
            {
                playerBox.Location = new Point(playerBox.Location.X, playerBox.Location.Y + speed);
            }
            elevator.Location = new Point(elevator.Location.X, elevator.Location.Y + speed);
            elevator_door.Location = new Point(elevator_door.Location.X, elevator_door.Location.Y + speed);
            chains.Location = new Point(chains.Location.X, chains.Location.Y + speed);
        }

        private void direction_indicator_timer_Tick(object sender, EventArgs e)
        {
            if (liftState == LiftState.MovingUp)
            {
                direction_indicator.BackgroundImage = upArrowGif;
            }
            else if (liftState.Equals(LiftState.MovingDown))
            {
                direction_indicator.BackgroundImage = downArrowGif;
            }
            else
            {
                direction_indicator.BackgroundImage = null;
            }
        }

        private void view_logs_btn_Click(object sender, EventArgs e)
        {
            if (!isLogsWindowOpen)
            {
                logsWindow.Show();
                isLogsWindowOpen = true;
            }
        }

        private void update_floor_level(bool increment)
        {
            if (increment) currentFloor++;

            else currentFloor--;

            floor_indicator_1.Text = currentFloor.ToString();
            floor_indicator_2.Text = currentFloor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogsWindowOpen)
            {
                logsWindow.Hide();
                isLogsWindowOpen = false;
            }
        }

        private async void call_button_1_Click(object sender, EventArgs e)
        {

            if (currentFloor == 1)
            {
                return;
            }

            if (liftState != LiftState.Idle)
            {
                return;
            }

            if (isPlayerNearLift)
            {
                return;
            }

            if (isDoorMoving)
            {
                return;
            }

            if (isDoorOpen)
            {
                close_door_timer.Start();
                await WaitForDoorToClose();
            }

            manager.PlayLiftMovingSound();
            move_down_timer.Start();
        }

        private async void call_button_2_Click(object sender, EventArgs e)
        {

            if (currentFloor == 2)
            {
                return;
            }

            if (liftState != LiftState.Idle)
            {
                return;
            }

            if (isPlayerNearLift)
            {
                return;
            }

            if (isDoorMoving)
            {
                return;
            }

            if (isDoorOpen)
            {
                close_door_timer.Start();
                await WaitForDoorToClose();
            }
            manager.PlayLiftMovingSound();
            move_up_timer.Start();
        }

        private void clearLogsBtn_Click(object sender, EventArgs e)
        {
            logger.ClearLogs(logsTable);
        }
    }
}
