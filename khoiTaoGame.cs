public bool checkZero(Label[,] Game)        //kiểm tra mảng có còn ô trống hay không
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (Game[i, j].Text == "")
                return true;
        }
    }
    return false;
}

public void addTile(Label[,] Game)          //Sinh một số tự nhiên tại một ô trống
{

    if (checkZero(Game) == false) return;
    //sinh 1 số tại vị trí x,y
    int x, y;
    Random rd = new Random();
    do
    {
        x = rd.Next(0, 4);
        y = rd.Next(0, 4);
    } while (Game[x, y].Text != "");

    int s = rd.Next(0, 100);
    if (s > 89) Game[x, y].Text = "4";
    else Game[x, y].Text = "2";
}

public void KhoiTaoGame()
{
    Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
    addTile(Game);
    CapNhatMau();
}