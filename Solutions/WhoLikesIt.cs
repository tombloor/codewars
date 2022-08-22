using System.Linq;

namespace Solutions.WhoLikesIt;

public static class Kata
{
    public static string Likes(string[] name)
    {
        string result = "";
        string suffix = name.Length >= 2 ? "like this" : "likes this";

        if (name.Length > 2)
        {
            result += $"{name[0]}, {name[1]} and ";
            if (name.Length == 3)
            {
                result += name[2];
            }
            else
            {
                result += $"{name.Length - 2} others";
            }
        }
        else if (name.Length == 0)
        {
            result += "no one";
        }
        else
        {
            result += string.Join(" and ", name);
        }

        return $"{result} {suffix}";
    }

    public static string Likes2(string[] name)
    {
        switch (name.Length)
        {
            case 0:
                return "no one likes this";
            case 1:
                return string.Format("{0} likes this", name[0]);
            case 2:
                return string.Format("{0} and {1} like this", name[0], name[1]);
            case 3:
                return string.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
            default:
                return string.Format("{0}, {1} and {2} others like this", name[0], name[1], name.Length - 2);
        }
    }
}