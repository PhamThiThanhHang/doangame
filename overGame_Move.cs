
bool overgame()
{

    for (int x = 0; x < 4; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            if (hide[x, y] == 0 ||
                (y < 3 && hide[x, y] == hide[x, y + 1]) ||
                (x < 3 && hide[x, y] == hide[x + 1, y]))
            {
                return false;
            }
        }
    }
    return true;
}
private void Form1_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyData == Keys.Up) Up();
    if (e.KeyData == Keys.Down) Down();
    if (e.KeyData == Keys.Left) Left();
    if (e.KeyData == Keys.Right) Right();

    this.Refresh(); // vô hiệu hóa định dạng ban đầu và vẽ lại 
                    //xử lý khi gameover
    if (overgame())
    {
        DialogResult dia = MessageBox.Show("SCORE: " + score.ToString() + "\n" + "Bạn có muốn chơi lại không?",
            "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dia == DialogResult.No) Application.Exit();
        if (dia == DialogResult.Yes)
        {
            highs = score;
            diemcao.Text = highs.ToString();
            init();
        }
    }
}