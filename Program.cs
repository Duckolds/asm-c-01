Console.WriteLine("water bill calculation program");
//khai bao ham xu ly chuong trinh
void Tinhtienhoadondiennuoc()
{
    Console.WriteLine("Enter the customer name :");
    String customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please select the customer type :");
    Console.WriteLine("Please enter number 1 if you are a family member");
    Console.WriteLine("Please enter number 2 if you are an administrative officer");
    Console.WriteLine("Please enter number 3 if you are a manufacturer");
    Console.WriteLine("Please enter number 4 if you are a business service");
    Console.WriteLine("then press enter !");
    int typecustomer = Convert.ToInt32(Console.ReadLine());
    if (typecustomer == 1)
    {
        //khach hang ho gia dinh
        // yeu cau nhap so luong nguoi trong gia dinh
        Console.WriteLine("enter the number of people in the family : ");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the previous month's water meter readings: ");
            int WaterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter this month's water meter readings: ");
            int WaterNumbercurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (WaterNumberLastMonth <= WaterNumbercurrentMonth)
            {
                int WaterNumber = WaterNumbercurrentMonth - WaterNumberLastMonth;
                double WaterNumberPeople = WaterNumber / numberMember;
                double money = 0;
                if (WaterNumberPeople > 0 && WaterNumber <= 10)
                {
                    money = WaterNumber * 5973 * 1.1;
                }
                else if (WaterNumberPeople > 10 && WaterNumberPeople <= 20)
                {
                    money = WaterNumber * 7051 * 1.1;
                }
                else if (WaterNumberPeople > 20 && WaterNumberPeople <= 30)
                {
                    money = WaterNumber * 8699 * 1.1;
                }
                else
                {
                    money = WaterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Your water bill this month is:{0}", money);


            }
            else
            {
                Console.WriteLine("This month's water number does not change from last month's!");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }

    }
    else if (typecustomer == 2)
    {
        //khach hang co quan hanh chinh cong
        Console.WriteLine("Enter the previous month's water meter readings: ");
        int WaterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's water meter readings: ");
        int WaterNumbercurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (WaterNumbercurrentMonth >= WaterNumberLastMonth)
        {
            double m = (WaterNumbercurrentMonth - WaterNumberLastMonth) * 9955 * 1.1;
            Console.WriteLine("Water fees of public administrative agencies are :{0}", m);
        }
        else
        {
            Console.WriteLine("This month's water number does not change from last month's!");
        }
    }
    else if (typecustomer == 3)
    {
        //khach hang don vi san xuat
        Console.WriteLine("Enter the previous month's water meter readings: ");
        int WaterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's water meter readings: ");
        int WaterNumbercurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (WaterNumbercurrentMonth >= WaterNumberLastMonth)
        {
            double n = (WaterNumbercurrentMonth - WaterNumberLastMonth) * 11615 * 1.1;
            Console.WriteLine("The production unit's water bill is: {0}", n);
        }
        else
        {
            Console.WriteLine("This month's water number does not change from last month's");
        }
    }
    else if (typecustomer == 4)
    {
        //khach hang dich vu kinh doanh
        Console.WriteLine("Enter the previous month's water meter readings: ");
        int WaterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's water meter readings: ");
        int WaterNumbercurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (WaterNumbercurrentMonth >= WaterNumberLastMonth)
        {
            double k = (WaterNumbercurrentMonth - WaterNumberLastMonth) * 22068 * 1.1;
            Console.WriteLine("Water charges for business services are: {0}", k);
        }
        else
        {
            Console.WriteLine("sThis month's water number does not change from last month's");
        }
    }
    else
    {
        Console.WriteLine("Please enter the correct instructions");
    }
}
//chay chuong trinh
Tinhtienhoadondiennuoc();