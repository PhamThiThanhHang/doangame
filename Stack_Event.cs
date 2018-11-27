
public void luuVaoStack()
{
    int[,] k = new int[4, 4];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            k[i, j] = hide[i, j];
    st.Push(k);
    st_score.Push(score);
}

public void kiemTra(bool isDo)
{
    if ((isDo) == true)
    {
        creatRandomCard();
    }
    else
    {
        st.Pop();
        st_score.Pop();
    }
}

public void move1(int x, int y, int y1, bool isDo)
{
    if (hide[x, y1] > 0)
    {
        if (hide[x, y] == 0)
        {
            hide[x, y] = hide[x, y1];
            hide[x, y1] = 0;
            y--;
            isDo = true;
        }
        else if (hide[x, y] == hide[x, y1])
        {
            hide[x, y] *= 2;
            hide[x, y1] = 0;
            score += hide[x, y];
            isDo = true;
        }
    }
}

public void move2(int y, int x, int x1, bool isDo)
{
    if (hide[x1, y] > 0)
    {
        if (hide[x, y] == 0)
        {
            hide[x, y] = hide[x1, y];
            hide[x1, y] = 0;
            x--;
            isDo = true;

        }
        else if (hide[x, y] == hide[x1, y])
        {
            hide[x, y] *= 2;
            hide[x1, y] = 0;
            score += hide[x, y];
            isDo = true;
        }
    }
}



private void undo_Click(object sender, EventArgs e)
{
    if (st.Count > 0)
    {
        int[,] k = new int[4, 4];
        k = st.Pop();
        score = st_score.Pop();
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                hide[i, j] = k[i, j];
        diem.Text = score.ToString();
        this.Refresh();

    }
}

private void newGame_Click(object sender, EventArgs e)
{
    highs = score;
    diemcao.Text = highs.ToString();
    init();
}

private void help_Click(object sender, EventArgs e)
{
    Help t = new Help();
    t.Show();
}
    

