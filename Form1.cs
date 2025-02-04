namespace PesticideSimulator
{
    public partial class Form1 : Form
    {
        Enemy enemy0 = new Enemy();
        Enemy enemy1 = new Enemy();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enemyButton0.Tag = enemy0;
            GrowEnemy(enemy0, enemyButton0);
            
            enemyButton1.Tag = enemy1;
            GrowEnemy(enemy1 , enemyButton1);
        }

        private async void GrowEnemy(Enemy enemy, Button enemyButton)
        {
            while (enemyButton.Width < 150 && enemyButton.Height < 150)
            {
                enemyButton.Width += 10;
                enemyButton.Height += 10;
                if (enemy.enemyStage < 11)
                {
                    enemy.enemyStage++;
                }
                await Task.Delay(500);
            }
        }

        private void DecreaseEnemy(Enemy enemy, Button enemyButton)
        {
            if (enemy.enemyStage < 10 && enemyButton.Width > 50 && enemyButton.Height > 50)
            {
                enemyButton.Width -= 10;
                enemyButton.Height -= 10;
                enemy.enemyStage--;
            }

        }

        private void enemy0_Click(object sender, EventArgs e)
        {
            DecreaseEnemy(enemy0, enemyButton0);
        }

        private void enemy1_Click(object sender, EventArgs e)
        {
            DecreaseEnemy(enemy1, enemyButton1);
        }
    }
}