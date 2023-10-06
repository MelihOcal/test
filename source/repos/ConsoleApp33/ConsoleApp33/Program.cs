// See https://aka.ms/new-console-template for more information





using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;





static string getday(int numday);

string days;



switch(numday)
{
    case 0:
        days = "monday";
        break;
    case 1:
        days = "tuesday";
        break;
    case 2:
        days = "wednsday";
        break;
    case 3:
        days = "thursday";
        break;
    case 4:
        days = "friday";
        break;
    case 5:
        days = "saturday";
        break;
    case 6:
        days = "sunday";
        break;
    case 7:
    default: days = "wrong number";
        break;

      


}

return days;







