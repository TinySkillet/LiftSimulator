using System.Media;

namespace LiftSimGame.Managers
{
    internal class AudioManager
    {
        private readonly SoundPlayer bgMusicPlayer;
        private readonly SoundPlayer elevatorPlayer;
        private readonly SoundPlayer liftPlayer;


        public AudioManager()
        {
            bgMusicPlayer = new SoundPlayer("resources\\BigChickies_music.wav");
            elevatorPlayer = new SoundPlayer("resources\\ElevatorOpening.wav");
            liftPlayer = new SoundPlayer("resources\\LiftMovingSound.wav");
        }

        public void PlayBgMusic()
        {
            bgMusicPlayer.PlayLooping();
        }

        public void StopBgMusic()
        {
            bgMusicPlayer.Stop();
        }

        public void PlayCallSound()
        {
            using SoundPlayer player = new("resources\\Collectible01.wav");
            player.Play();
        }

        public void PlayElevatorDoorSound()
        {
            elevatorPlayer.Stop();
            elevatorPlayer.Play();
        }

        public void PlayLiftMovingSound()
        {
            liftPlayer.Stop();
            liftPlayer.PlayLooping();
        }

    }
}
