namespace Cocos_Alexandru_Lab2
{
    internal class DoughnutMachineBase
    {
        DispatcherTimer doughnutTimer;
        private void InitializeComponent()
        {
            this.doughnutTimer = new DispatcherTimer();
            this.doughnutTimer.Tick += new System.EventHandler(this.doughnutTimer_Tick);
        }
    }
}