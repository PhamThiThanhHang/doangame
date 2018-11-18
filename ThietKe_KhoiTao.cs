private int kc = 10; // tạo khoảng cách giữa 2 label
private Label[,] show = new Label[4, 4];//mảng trình bày
private int score = 0;// tạo tổng điểm
private int[,] hide = new int[4, 4];//mảng ẩn
Stack<int[,]> st = new Stack<int[,]>();
public Form1()
{
    InitializeComponent();
}
public void Form_loading(object sender, EventArgs e)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            show[i, j] = new Label();//tạo 1 label mới :)
            show[i, j].Location = new Point(kc + i * (100 + kc), kc + j * (100 + kc));
            show[i, j].Size = new Size(100, 100);
            show[i, j].BackColor = Color.GhostWhite;
            show[i, j].TabIndex = i * 4 + j;
            show[i, j].Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            show[i, j].TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(show[i, j]);//thêm label vào màn hình control
        }
    }
    //tạo các giá trị ban đầu
    init();
}
public void Form_design(object sender, PaintEventArgs e)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (hide[i, j] == 0)
                show[i, j].Text = " ";
            if (hide[i, j] != 0)
            {
                show[i, j].Text = hide[i, j].ToString();
            }
            datmau(i, j);
        }
    }
    Lscore.Text = score.ToString();
}
public void creatRandomCard()
{
    //sinh 1 số tại vị trí x,y
    int x, y;
    Random rd = new Random();
    do
    {
        x = rd.Next(0, 4);
        y = rd.Next(0, 4);
    } while (hide[x, y] != 0);
    int s = rd.Next(0, 100);
    if (s > 89) hide[x, y] = 4;
    else hide[x, y] = 2;
    score = score + hide[x, y];
}
public void init()
{
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            hide[i, j] = 0;
    creatRandomCard();
    creatRandomCard();
    int[,] k = new int[4, 4];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            k[i, j] = hide[i, j];
    st.Push(k);
    this.Refresh();
}
public void No()
{
    int[,] k = press_no();
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            hide[i, j] = k[i, j];
            this.Refresh();
}
public int[,] press_no()
{
    int[,] k = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        st.Pop();
    }
    k = st.Peek();
    return k;

}

