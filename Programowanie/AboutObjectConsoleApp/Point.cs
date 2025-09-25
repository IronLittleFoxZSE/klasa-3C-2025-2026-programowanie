
namespace AboutObjectConsoleApp;

internal class Point /*: Object*/
{
    protected int x;
    public int X
    {
        get
        {
            return x;
        }

        set /*(int value)*/
        {
            //if (value >= 0)
            x = value;
        }
    }

    //private int y;
    //public int Y
    //{
    //    get
    //    {
    //        return y;
    //    }

    //    set
    //    {
    //        y = value;
    //    }
    //}
    public int Y { get; set; }


    public Point()
    {
        x = 5;
        Y = 8;
    }

    public Point(int a, int b)
    {
        x = a; 
        Y = b;
    }

    public void Show()
    {
        Console.WriteLine($"({x},{Y})");
    }

    public void SetX(int x)
    {
        //if (x >= 0)
        this.x = x;
    }

    public int GetX()
    {
        return x;
    }
}
