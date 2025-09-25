using ObjectConsoleApp;

PointStruct firstPointStruct;
firstPointStruct.x = 5;
firstPointStruct.y = 6;

Console.WriteLine($"firstPointStruct ({firstPointStruct.x} , {firstPointStruct.y})");

PointStruct secondPointStruct = firstPointStruct;
secondPointStruct.x = 7;

Console.WriteLine($"firstPointStruct ({firstPointStruct.x} , {firstPointStruct.y})");
Console.WriteLine($"secondPointStruct ({secondPointStruct.x} , {secondPointStruct.y})");

void ParametrTestStruct_v1(PointStruct ps)
{
    Console.WriteLine($"ParametrTestStruct_v1 ({ps.x} , {ps.y})");
    ps.x = 99;
    Console.WriteLine($"ParametrTestStruct_v1 ({ps.x} , {ps.y})");
}
void ParametrTestStruct_v2(ref PointStruct ps)
{
    Console.WriteLine($"ParametrTestStruct_v2 ({ps.x} , {ps.y})");
    ps.x = 99;
    Console.WriteLine($"ParametrTestStruct_v2 ({ps.x} , {ps.y})");
}

ParametrTestStruct_v1(firstPointStruct);
Console.WriteLine($"firstPointStruct ({firstPointStruct.x} , {firstPointStruct.y})");

ParametrTestStruct_v2(ref firstPointStruct);
Console.WriteLine($"firstPointStruct ({firstPointStruct.x} , {firstPointStruct.y})");


//--------------------------------------------------------------------

PointClass firstPointClass = new PointClass();
firstPointClass.x = 15;
firstPointClass.y = 99;

Console.WriteLine($"firstPointClass ({firstPointClass.x} , {firstPointClass.y})");

PointClass secondPointClass = firstPointClass;
secondPointClass.x = 29;

Console.WriteLine($"firstPointClass ({firstPointClass.x} , {firstPointClass.y})");
Console.WriteLine($"secondPointClass ({secondPointClass.x} , {secondPointClass.y})");

void ParametrTestClass_v1(PointClass pc)
{
    Console.WriteLine($"ParametrTestClass_v1 ({pc.x} , {pc.y})");
    pc.x = 79;
    Console.WriteLine($"ParametrTestClass_v1 ({pc.x} , {pc.y})");
}

void ParametrTestClass_v2(PointClass pc)
{
    Console.WriteLine($"ParametrTestClass_v2 ({pc.x} , {pc.y})");
    pc = new PointClass();
    pc.x = 45;
    Console.WriteLine($"ParametrTestClass_v2 ({pc.x} , {pc.y})");
}

void ParametrTestClass_v3(ref PointClass pc)
{
    Console.WriteLine($"ParametrTestClass_v3 ({pc.x} , {pc.y})");
    pc = new PointClass();
    pc.x = 45;
    Console.WriteLine($"ParametrTestClass_v3 ({pc.x} , {pc.y})");
}

ParametrTestClass_v1(firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x} , {firstPointClass.y})");

ParametrTestClass_v2(firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x} , {firstPointClass.y})");

ParametrTestClass_v3(ref firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x} , {firstPointClass.y})");

