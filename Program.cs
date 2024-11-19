
Console.WriteLine(GymMemberShip(34, false));



int GymMemberShip(int age, bool premium)
{
    int membershipCost = 0;
    if (premium) membershipCost = 300;

    if (age <= 19 || age >= 64)
    {
        membershipCost += 2200;
    }
    else
    {
        membershipCost += 3100;
    }
    return membershipCost;
}
