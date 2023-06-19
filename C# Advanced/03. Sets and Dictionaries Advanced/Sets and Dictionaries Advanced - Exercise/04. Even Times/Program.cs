int inputTimes = int.Parse(Console.ReadLine());
Dictionary<int, int> nums = new Dictionary<int, int>();

for(int i = 0; i < inputTimes; i++)
{
    int num = int.Parse(Console.ReadLine());
    if(!nums.ContainsKey(num))
    {
        nums.Add(num, 1);
    }
    else
    {
        nums[num]++;
    }
}

foreach(var num in nums)
{
    if(num.Value % 2 == 0)
    {
        Console.WriteLine(num.Key);
    }
}