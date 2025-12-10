
using System.Numerics;
using System.Runtime.InteropServices;

namespace PolymorphismConsoleApp;

internal abstract class Figure: IWorkOnFiles
{
    protected string name;

    public /*virtual*/ abstract double GetPerimieter();
    /*{
        return 0;
    }*/

    public abstract double GetArea();

    public abstract void SaveToFile();
}
