using LiftSimGame.Database;

namespace LiftSimGame
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Panel chicken_coop;
            Panel panel11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            panel24 = new Panel();
            panel23 = new Panel();
            panel22 = new Panel();
            panel18 = new Panel();
            floor = new Panel();
            wooden_pole2 = new Panel();
            windmill = new Panel();
            egg_basket = new Panel();
            elevator = new Panel();
            elevator_inside = new Panel();
            floor_indicator_1 = new TextBox();
            elevator_door = new Panel();
            wooden_pole1 = new Panel();
            panel2 = new Panel();
            left_boundary = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            chains = new Panel();
            panel13 = new Panel();
            panel12 = new Panel();
            panel14 = new Panel();
            right_boundary = new Panel();
            panel100 = new Panel();
            panel17 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            playerBox = new PictureBox();
            playerTimer = new System.Windows.Forms.Timer(components);
            open_door_timer = new System.Windows.Forms.Timer(components);
            player_in_lift_timer = new System.Windows.Forms.Timer(components);
            player_near_lift_timer = new System.Windows.Forms.Timer(components);
            close_door_timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            controls_heading = new Label();
            direction_indicator = new PictureBox();
            floor_indicator_2 = new Button();
            up_button = new Button();
            down_button = new Button();
            open_button = new Button();
            close_button = new Button();
            view_logs_btn = new Button();
            move_up_timer = new System.Windows.Forms.Timer(components);
            move_down_timer = new System.Windows.Forms.Timer(components);
            direction_indicator_timer = new System.Windows.Forms.Timer(components);
            logsWindow = new Panel();
            clearLogsBtn = new Button();
            logsTable = new DataGridView();
            button1 = new Button();
            close_logs_btn = new Button();
            liftSimDatabaseBindingSource = new BindingSource(components);
            label1 = new Label();
            panel1 = new Panel();
            call_button_1 = new Button();
            panel3 = new Panel();
            call_button_2 = new Button();
            chicken_coop = new Panel();
            panel11 = new Panel();
            panel11.SuspendLayout();
            elevator.SuspendLayout();
            elevator_door.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)direction_indicator).BeginInit();
            logsWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liftSimDatabaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // chicken_coop
            // 
            chicken_coop.Anchor = AnchorStyles.Bottom;
            chicken_coop.BackColor = Color.Transparent;
            chicken_coop.BackgroundImage = LiftSimulator.Properties.Resources.ChickenCoop;
            chicken_coop.BackgroundImageLayout = ImageLayout.Stretch;
            chicken_coop.Location = new Point(2596, 1076);
            chicken_coop.Name = "chicken_coop";
            chicken_coop.Size = new Size(128, 368);
            chicken_coop.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.Transparent;
            panel11.BackgroundImage = LiftSimulator.Properties.Resources.ChickenCoopFront;
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Controls.Add(panel24);
            panel11.Controls.Add(panel23);
            panel11.Controls.Add(panel22);
            panel11.Controls.Add(panel18);
            panel11.Location = new Point(334, 171);
            panel11.Name = "panel11";
            panel11.Size = new Size(128, 368);
            panel11.TabIndex = 17;
            // 
            // panel24
            // 
            panel24.Anchor = AnchorStyles.Top;
            panel24.BackColor = Color.Transparent;
            panel24.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full04;
            panel24.BackgroundImageLayout = ImageLayout.Zoom;
            panel24.Location = new Point(24, 46);
            panel24.Name = "panel24";
            panel24.Size = new Size(85, 77);
            panel24.TabIndex = 31;
            // 
            // panel23
            // 
            panel23.Anchor = AnchorStyles.Top;
            panel23.BackColor = Color.Transparent;
            panel23.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full06;
            panel23.BackgroundImageLayout = ImageLayout.Zoom;
            panel23.Location = new Point(24, 116);
            panel23.Name = "panel23";
            panel23.Size = new Size(85, 77);
            panel23.TabIndex = 30;
            // 
            // panel22
            // 
            panel22.Anchor = AnchorStyles.Top;
            panel22.BackColor = Color.Transparent;
            panel22.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full06;
            panel22.BackgroundImageLayout = ImageLayout.Zoom;
            panel22.Location = new Point(24, 182);
            panel22.Name = "panel22";
            panel22.Size = new Size(85, 77);
            panel22.TabIndex = 30;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top;
            panel18.BackColor = Color.Transparent;
            panel18.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full03;
            panel18.BackgroundImageLayout = ImageLayout.Zoom;
            panel18.Location = new Point(23, 209);
            panel18.Name = "panel18";
            panel18.Size = new Size(85, 77);
            panel18.TabIndex = 29;
            // 
            // floor
            // 
            floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            floor.BackColor = Color.Transparent;
            floor.BackgroundImage = LiftSimulator.Properties.Resources.Floor;
            floor.Location = new Point(-4, 1437);
            floor.Margin = new Padding(1);
            floor.Name = "floor";
            floor.Size = new Size(2887, 41);
            floor.TabIndex = 0;
            // 
            // wooden_pole2
            // 
            wooden_pole2.Anchor = AnchorStyles.Top;
            wooden_pole2.BackColor = Color.Transparent;
            wooden_pole2.BackgroundImage = (Image)resources.GetObject("wooden_pole2.BackgroundImage");
            wooden_pole2.BackgroundImageLayout = ImageLayout.Stretch;
            wooden_pole2.Location = new Point(2898, 203);
            wooden_pole2.Name = "wooden_pole2";
            wooden_pole2.Size = new Size(120, 418);
            wooden_pole2.TabIndex = 2;
            // 
            // windmill
            // 
            windmill.BackColor = Color.Transparent;
            windmill.BackgroundImage = LiftSimulator.Properties.Resources.GB_WindMill;
            windmill.BackgroundImageLayout = ImageLayout.None;
            windmill.Location = new Point(1, 12);
            windmill.Name = "windmill";
            windmill.Size = new Size(315, 510);
            windmill.TabIndex = 3;
            // 
            // egg_basket
            // 
            egg_basket.Anchor = AnchorStyles.Bottom;
            egg_basket.BackColor = Color.Transparent;
            egg_basket.BackgroundImage = LiftSimulator.Properties.Resources.Box;
            egg_basket.BackgroundImageLayout = ImageLayout.Stretch;
            egg_basket.Location = new Point(2743, 1366);
            egg_basket.Name = "egg_basket";
            egg_basket.Size = new Size(117, 78);
            egg_basket.TabIndex = 5;
            // 
            // elevator
            // 
            elevator.Anchor = AnchorStyles.Bottom;
            elevator.BackColor = Color.Transparent;
            elevator.BackgroundImage = LiftSimulator.Properties.Resources.elevator;
            elevator.BackgroundImageLayout = ImageLayout.Stretch;
            elevator.Controls.Add(elevator_inside);
            elevator.Location = new Point(2120, 1050);
            elevator.Name = "elevator";
            elevator.Size = new Size(221, 407);
            elevator.TabIndex = 6;
            // 
            // elevator_inside
            // 
            elevator_inside.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            elevator_inside.BackColor = Color.FromArgb(221, 159, 93);
            elevator_inside.Location = new Point(21, 83);
            elevator_inside.Name = "elevator_inside";
            elevator_inside.Size = new Size(180, 301);
            elevator_inside.TabIndex = 7;
            // 
            // floor_indicator_1
            // 
            floor_indicator_1.BackColor = Color.LightSalmon;
            floor_indicator_1.Enabled = false;
            floor_indicator_1.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor_indicator_1.ForeColor = SystemColors.Window;
            floor_indicator_1.Location = new Point(59, 219);
            floor_indicator_1.Margin = new Padding(0);
            floor_indicator_1.MaxLength = 32;
            floor_indicator_1.Name = "floor_indicator_1";
            floor_indicator_1.Size = new Size(68, 67);
            floor_indicator_1.TabIndex = 32;
            floor_indicator_1.Text = "1";
            floor_indicator_1.TextAlign = HorizontalAlignment.Center;
            // 
            // elevator_door
            // 
            elevator_door.Anchor = AnchorStyles.Bottom;
            elevator_door.BackColor = Color.Transparent;
            elevator_door.BackgroundImage = LiftSimulator.Properties.Resources.elevator_door;
            elevator_door.BackgroundImageLayout = ImageLayout.Center;
            elevator_door.Controls.Add(floor_indicator_1);
            elevator_door.Location = new Point(2139, 1131);
            elevator_door.Name = "elevator_door";
            elevator_door.Size = new Size(191, 303);
            elevator_door.TabIndex = 7;
            // 
            // wooden_pole1
            // 
            wooden_pole1.Anchor = AnchorStyles.Top;
            wooden_pole1.BackColor = Color.Transparent;
            wooden_pole1.BackgroundImage = (Image)resources.GetObject("wooden_pole1.BackgroundImage");
            wooden_pole1.Location = new Point(2893, -53);
            wooden_pole1.Name = "wooden_pole1";
            wooden_pole1.Size = new Size(79, 260);
            wooden_pole1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(435, 614);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1686, 41);
            panel2.TabIndex = 8;
            // 
            // left_boundary
            // 
            left_boundary.Anchor = AnchorStyles.Top;
            left_boundary.BackColor = Color.Transparent;
            left_boundary.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            left_boundary.Location = new Point(389, 523);
            left_boundary.Name = "left_boundary";
            left_boundary.Size = new Size(84, 98);
            left_boundary.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = LiftSimulator.Properties.Resources.Platform;
            panel4.Location = new Point(-103, 523);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 41);
            panel4.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = LiftSimulator.Properties.Resources.Platform;
            panel6.Location = new Point(2347, 614);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1693, 41);
            panel6.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Location = new Point(2756, 414);
            panel7.Name = "panel7";
            panel7.Size = new Size(84, 200);
            panel7.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Location = new Point(2755, 227);
            panel8.Name = "panel8";
            panel8.Size = new Size(84, 200);
            panel8.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = LiftSimulator.Properties.Resources.Weapon_stand;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Location = new Point(2610, 446);
            panel9.Name = "panel9";
            panel9.Size = new Size(170, 180);
            panel9.TabIndex = 14;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = LiftSimulator.Properties.Resources.Zone_Shovels;
            panel10.Location = new Point(468, 475);
            panel10.Name = "panel10";
            panel10.Size = new Size(170, 146);
            panel10.TabIndex = 15;
            // 
            // chains
            // 
            chains.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chains.BackColor = Color.Transparent;
            chains.BackgroundImage = LiftSimulator.Properties.Resources.chain_1_;
            chains.Location = new Point(2215, -158);
            chains.Name = "chains";
            chains.Size = new Size(37, 1221);
            chains.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top;
            panel13.BackColor = Color.Transparent;
            panel13.BackgroundImage = LiftSimulator.Properties.Resources.Bag;
            panel13.Location = new Point(644, 522);
            panel13.Name = "panel13";
            panel13.Size = new Size(177, 99);
            panel13.TabIndex = 19;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Bottom;
            panel12.BackColor = Color.Transparent;
            panel12.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel12.Location = new Point(249, 735);
            panel12.Name = "panel12";
            panel12.Size = new Size(137, 709);
            panel12.TabIndex = 20;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Bottom;
            panel14.BackColor = Color.Transparent;
            panel14.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel14.BackgroundImageLayout = ImageLayout.None;
            panel14.Location = new Point(249, 466);
            panel14.Name = "panel14";
            panel14.Size = new Size(93, 321);
            panel14.TabIndex = 21;
            // 
            // right_boundary
            // 
            right_boundary.Anchor = AnchorStyles.Top;
            right_boundary.BackColor = Color.Transparent;
            right_boundary.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            right_boundary.BackgroundImageLayout = ImageLayout.None;
            right_boundary.Location = new Point(2395, 556);
            right_boundary.Name = "right_boundary";
            right_boundary.Size = new Size(87, 351);
            right_boundary.TabIndex = 23;
            // 
            // panel100
            // 
            panel100.Anchor = AnchorStyles.Bottom;
            panel100.BackColor = Color.Transparent;
            panel100.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel100.Location = new Point(2393, 732);
            panel100.Name = "panel100";
            panel100.Size = new Size(135, 720);
            panel100.TabIndex = 22;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Transparent;
            panel17.BackgroundImage = (Image)resources.GetObject("panel17.BackgroundImage");
            panel17.Location = new Point(2417, 536);
            panel17.Name = "panel17";
            panel17.Size = new Size(146, 82);
            panel17.TabIndex = 24;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.Top;
            panel19.BackColor = Color.Transparent;
            panel19.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full03;
            panel19.BackgroundImageLayout = ImageLayout.Stretch;
            panel19.Location = new Point(827, 511);
            panel19.Name = "panel19";
            panel19.Size = new Size(101, 110);
            panel19.TabIndex = 26;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.Top;
            panel20.BackColor = Color.Transparent;
            panel20.BackgroundImage = LiftSimulator.Properties.Resources.Eggs_Full01;
            panel20.BackgroundImageLayout = ImageLayout.Stretch;
            panel20.Location = new Point(934, 511);
            panel20.Name = "panel20";
            panel20.Size = new Size(101, 110);
            panel20.TabIndex = 27;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Top;
            panel21.BackColor = Color.Transparent;
            panel21.BackgroundImage = (Image)resources.GetObject("panel21.BackgroundImage");
            panel21.BackgroundImageLayout = ImageLayout.Stretch;
            panel21.Location = new Point(1041, 581);
            panel21.Name = "panel21";
            panel21.Size = new Size(29, 40);
            panel21.TabIndex = 28;
            // 
            // playerBox
            // 
            playerBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerBox.BackColor = Color.Transparent;
            playerBox.BackgroundImageLayout = ImageLayout.Stretch;
            playerBox.Location = new Point(1586, 1292);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(159, 152);
            playerBox.TabIndex = 29;
            playerBox.TabStop = false;
            playerBox.WaitOnLoad = true;
            // 
            // playerTimer
            // 
            playerTimer.Enabled = true;
            playerTimer.Interval = 10;
            playerTimer.Tick += playerTimer_Tick;
            // 
            // open_door_timer
            // 
            open_door_timer.Interval = 16;
            open_door_timer.Tick += open_door_timer_Tick;
            // 
            // player_in_lift_timer
            // 
            player_in_lift_timer.Enabled = true;
            player_in_lift_timer.Tick += player_in_lift_timer_Tick;
            // 
            // player_near_lift_timer
            // 
            player_near_lift_timer.Enabled = true;
            player_near_lift_timer.Tick += player_near_lift_timer_Tick;
            // 
            // close_door_timer
            // 
            close_door_timer.Interval = 16;
            close_door_timer.Tick += close_door_timer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.WindowFrame;
            flowLayoutPanel1.Controls.Add(controls_heading);
            flowLayoutPanel1.Controls.Add(direction_indicator);
            flowLayoutPanel1.Controls.Add(floor_indicator_2);
            flowLayoutPanel1.Controls.Add(up_button);
            flowLayoutPanel1.Controls.Add(down_button);
            flowLayoutPanel1.Controls.Add(open_button);
            flowLayoutPanel1.Controls.Add(close_button);
            flowLayoutPanel1.Controls.Add(view_logs_btn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-8, 488);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 10, 10, 10);
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(309, 970);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // controls_heading
            // 
            controls_heading.AutoSize = true;
            controls_heading.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controls_heading.ForeColor = SystemColors.ButtonFace;
            controls_heading.Location = new Point(26, 10);
            controls_heading.Name = "controls_heading";
            controls_heading.Size = new Size(270, 45);
            controls_heading.TabIndex = 0;
            controls_heading.Text = "Master Controls";
            controls_heading.TextAlign = ContentAlignment.TopCenter;
            // 
            // direction_indicator
            // 
            direction_indicator.Anchor = AnchorStyles.None;
            direction_indicator.BackColor = Color.Black;
            direction_indicator.BackgroundImageLayout = ImageLayout.Stretch;
            direction_indicator.Location = new Point(106, 90);
            direction_indicator.Margin = new Padding(3, 35, 3, 35);
            direction_indicator.Name = "direction_indicator";
            direction_indicator.Size = new Size(111, 119);
            direction_indicator.TabIndex = 31;
            direction_indicator.TabStop = false;
            // 
            // floor_indicator_2
            // 
            floor_indicator_2.Anchor = AnchorStyles.None;
            floor_indicator_2.BackColor = Color.FromArgb(219, 216, 219);
            floor_indicator_2.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor_indicator_2.Location = new Point(112, 244);
            floor_indicator_2.Margin = new Padding(3, 0, 3, 3);
            floor_indicator_2.Name = "floor_indicator_2";
            floor_indicator_2.Size = new Size(98, 98);
            floor_indicator_2.TabIndex = 34;
            floor_indicator_2.Text = "1";
            floor_indicator_2.UseVisualStyleBackColor = false;
            // 
            // up_button
            // 
            up_button.Anchor = AnchorStyles.None;
            up_button.BackColor = Color.FromArgb(219, 216, 219);
            up_button.BackgroundImage = LiftSimulator.Properties.Resources.up_arrow;
            up_button.BackgroundImageLayout = ImageLayout.Stretch;
            up_button.Location = new Point(112, 375);
            up_button.Margin = new Padding(3, 30, 3, 3);
            up_button.Name = "up_button";
            up_button.Size = new Size(98, 98);
            up_button.TabIndex = 33;
            up_button.UseVisualStyleBackColor = false;
            up_button.Click += up_button_Click;
            // 
            // down_button
            // 
            down_button.Anchor = AnchorStyles.None;
            down_button.BackColor = Color.FromArgb(219, 216, 219);
            down_button.BackgroundImage = LiftSimulator.Properties.Resources.down_arrow;
            down_button.BackgroundImageLayout = ImageLayout.Stretch;
            down_button.Location = new Point(112, 506);
            down_button.Margin = new Padding(3, 30, 3, 3);
            down_button.Name = "down_button";
            down_button.Size = new Size(98, 98);
            down_button.TabIndex = 32;
            down_button.UseVisualStyleBackColor = false;
            down_button.Click += down_button_Click;
            // 
            // open_button
            // 
            open_button.Anchor = AnchorStyles.None;
            open_button.BackColor = Color.FromArgb(219, 216, 219);
            open_button.BackgroundImage = LiftSimulator.Properties.Resources.open_elevator;
            open_button.BackgroundImageLayout = ImageLayout.Stretch;
            open_button.Location = new Point(112, 637);
            open_button.Margin = new Padding(3, 30, 3, 3);
            open_button.Name = "open_button";
            open_button.Size = new Size(98, 98);
            open_button.TabIndex = 34;
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += open_button_Click;
            // 
            // close_button
            // 
            close_button.Anchor = AnchorStyles.None;
            close_button.BackColor = Color.FromArgb(219, 216, 219);
            close_button.BackgroundImage = LiftSimulator.Properties.Resources.close_elevator;
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Location = new Point(112, 768);
            close_button.Margin = new Padding(3, 30, 3, 3);
            close_button.Name = "close_button";
            close_button.Size = new Size(98, 98);
            close_button.TabIndex = 35;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // view_logs_btn
            // 
            view_logs_btn.Anchor = AnchorStyles.None;
            view_logs_btn.BackColor = Color.FromArgb(255, 192, 128);
            view_logs_btn.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view_logs_btn.Location = new Point(77, 889);
            view_logs_btn.Margin = new Padding(3, 20, 3, 3);
            view_logs_btn.Name = "view_logs_btn";
            view_logs_btn.Size = new Size(168, 55);
            view_logs_btn.TabIndex = 32;
            view_logs_btn.Text = "View Logs";
            view_logs_btn.UseVisualStyleBackColor = false;
            view_logs_btn.Click += view_logs_btn_Click;
            // 
            // move_up_timer
            // 
            move_up_timer.Interval = 10;
            move_up_timer.Tick += move_up_timer_Tick;
            // 
            // move_down_timer
            // 
            move_down_timer.Interval = 1;
            move_down_timer.Tick += move_down_timer_Tick;
            // 
            // direction_indicator_timer
            // 
            direction_indicator_timer.Enabled = true;
            direction_indicator_timer.Tick += direction_indicator_timer_Tick;
            // 
            // logsWindow
            // 
            logsWindow.Anchor = AnchorStyles.Bottom;
            logsWindow.Controls.Add(clearLogsBtn);
            logsWindow.Controls.Add(logsTable);
            logsWindow.Controls.Add(button1);
            logsWindow.Controls.Add(close_logs_btn);
            logsWindow.Location = new Point(436, 581);
            logsWindow.Name = "logsWindow";
            logsWindow.Size = new Size(846, 775);
            logsWindow.TabIndex = 31;
            // 
            // clearLogsBtn
            // 
            clearLogsBtn.Anchor = AnchorStyles.None;
            clearLogsBtn.BackColor = Color.FromArgb(255, 192, 128);
            clearLogsBtn.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearLogsBtn.Location = new Point(572, 0);
            clearLogsBtn.Margin = new Padding(3, 20, 3, 3);
            clearLogsBtn.Name = "clearLogsBtn";
            clearLogsBtn.Size = new Size(202, 69);
            clearLogsBtn.TabIndex = 38;
            clearLogsBtn.Text = "Clear";
            clearLogsBtn.UseVisualStyleBackColor = false;
            clearLogsBtn.Click += clearLogsBtn_Click;
            // 
            // logsTable
            // 
            logsTable.Anchor = AnchorStyles.Top;
            logsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            logsTable.BackgroundColor = Color.FromArgb(255, 224, 192);
            logsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logsTable.Location = new Point(3, 73);
            logsTable.Name = "logsTable";
            logsTable.RowHeadersWidth = 82;
            logsTable.Size = new Size(840, 699);
            logsTable.TabIndex = 35;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(780, 0);
            button1.Margin = new Padding(3, 20, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(66, 69);
            button1.TabIndex = 34;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // close_logs_btn
            // 
            close_logs_btn.Anchor = AnchorStyles.None;
            close_logs_btn.BackColor = Color.FromArgb(255, 192, 128);
            close_logs_btn.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_logs_btn.Location = new Point(0, 0);
            close_logs_btn.Margin = new Padding(3, 20, 3, 3);
            close_logs_btn.Name = "close_logs_btn";
            close_logs_btn.Size = new Size(433, 69);
            close_logs_btn.TabIndex = 33;
            close_logs_btn.Text = "Logs";
            close_logs_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(1289, 3);
            label1.Name = "label1";
            label1.Size = new Size(439, 82);
            label1.TabIndex = 32;
            label1.Text = "Lift Simulator";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel1.Location = new Point(1900, 1350);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 106);
            panel1.TabIndex = 33;
            // 
            // call_button_1
            // 
            call_button_1.Anchor = AnchorStyles.None;
            call_button_1.BackColor = Color.FromArgb(221, 159, 93);
            call_button_1.BackgroundImageLayout = ImageLayout.Stretch;
            call_button_1.Font = new Font("Comic Sans MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            call_button_1.ForeColor = SystemColors.ControlLight;
            call_button_1.Location = new Point(1914, 1338);
            call_button_1.Margin = new Padding(3, 30, 3, 3);
            call_button_1.Name = "call_button_1";
            call_button_1.Size = new Size(102, 58);
            call_button_1.TabIndex = 34;
            call_button_1.Text = "Call";
            call_button_1.UseVisualStyleBackColor = false;
            call_button_1.Click += call_button_1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = LiftSimulator.Properties.Resources.Platform_back;
            panel3.Location = new Point(1900, 446);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 125);
            panel3.TabIndex = 35;
            // 
            // call_button_2
            // 
            call_button_2.Anchor = AnchorStyles.None;
            call_button_2.BackColor = Color.FromArgb(221, 159, 93);
            call_button_2.BackgroundImageLayout = ImageLayout.Stretch;
            call_button_2.Font = new Font("Comic Sans MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            call_button_2.ForeColor = SystemColors.ControlLight;
            call_button_2.Location = new Point(1914, 446);
            call_button_2.Margin = new Padding(3, 30, 3, 3);
            call_button_2.Name = "call_button_2";
            call_button_2.Size = new Size(102, 58);
            call_button_2.TabIndex = 37;
            call_button_2.Text = "Call";
            call_button_2.UseVisualStyleBackColor = false;
            call_button_2.Click += call_button_2_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 159, 93);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2884, 1680);
            Controls.Add(floor);
            Controls.Add(call_button_2);
            Controls.Add(call_button_1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(logsWindow);
            Controls.Add(panel2);
            Controls.Add(elevator_door);
            Controls.Add(playerBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel17);
            Controls.Add(panel6);
            Controls.Add(panel19);
            Controls.Add(right_boundary);
            Controls.Add(panel4);
            Controls.Add(panel14);
            Controls.Add(panel10);
            Controls.Add(panel13);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(left_boundary);
            Controls.Add(wooden_pole1);
            Controls.Add(wooden_pole2);
            Controls.Add(windmill);
            Controls.Add(egg_basket);
            Controls.Add(chicken_coop);
            Controls.Add(elevator);
            Controls.Add(panel9);
            Controls.Add(panel11);
            Controls.Add(panel20);
            Controls.Add(panel21);
            Controls.Add(panel12);
            Controls.Add(panel100);
            Controls.Add(chains);
            Controls.Add(panel3);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosed += MainScreen_FormClosed;
            Load += MainScreen_Load;
            KeyDown += MainScreen_KeyDown;
            KeyUp += MainScreen_KeyUp;
            panel11.ResumeLayout(false);
            elevator.ResumeLayout(false);
            elevator_door.ResumeLayout(false);
            elevator_door.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)direction_indicator).EndInit();
            logsWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)liftSimDatabaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel floor;
        private Panel wooden_pole2;
        private Panel windmill;
        private Panel egg_basket;
        private Panel elevator;
        private Panel elevator_inside;
        private Panel elevator_door;
        private Panel wooden_pole1;
        private Panel panel2;
        private Panel left_boundary;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel chains;
        private Panel panel13;
        private Panel panel12;
        private Panel panel14;
        private Panel right_boundary;
        private Panel panel100;
        private Panel panel17;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel18;
        private Panel panel23;
        private Panel panel24;
        private PictureBox playerBox;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Timer player_in_lift_timer;
        private System.Windows.Forms.Timer player_near_lift_timer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label controls_heading;
        private Button down_button;
        private Button up_button;
        private Button close_button;
        private Button open_button;
        private System.Windows.Forms.Timer move_up_timer;
        private System.Windows.Forms.Timer move_down_timer;
        private System.Windows.Forms.Timer direction_indicator_timer;
        private PictureBox direction_indicator;
        private Button view_logs_btn;
        private Panel logsWindow;
        private Button close_logs_btn;
        private Button button1;
        private BindingSource liftSimDatabaseBindingSource;
        protected DataGridView logsTable;
        private TextBox floor_indicator_1;
        private Button floor_indicator_2;
        private Label label1;
        private Panel panel1;
        private Button call_button_1;
        private Panel panel3;
        private Button call_button_2;
        public System.Windows.Forms.Timer open_door_timer;
        public System.Windows.Forms.Timer close_door_timer;
        private Button clearLogsBtn;
    }
}