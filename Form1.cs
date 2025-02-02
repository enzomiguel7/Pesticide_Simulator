namespace PesticideSimulator
{
    public partial class Form1 : Form
    {
        Enemy enemy0 = new Enemy();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enemyButton0.Tag = enemy0;
            GrowEnemy(enemy0, enemyButton0);
        }

        private async void GrowEnemy(Enemy enemy, Button enemyButton)
        {
            while (enemyButton.Width < 150 && enemyButton.Height < 150)
            {
                enemyButton.Width += 10;
                enemyButton.Height += 10;
                await Task.Delay(500);
            }
        }

        private void DecreaseEnemy(Enemy enemy, Button enemyButton)
        {
            enemyButton.Width -= 10;
            enemyButton.Height -= 10;
        }

        private void enemy0_Click(object sender, EventArgs e)
        {
            DecreaseEnemy(enemy0, enemyButton0);
        }

    }
}