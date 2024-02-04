using System;
using System.Linq;
using System.Runtime.InteropServices;

public static class Bob
{
    public static string Response(string statement)
    {
        var message=statement.Trim();
        if(string.IsNullOrWhiteSpace(message)){
            return "Fine. Be that way!";
        }
    else if(message.Equals(message.ToUpper()) && message.Any(char.IsLetter)){
        if(message.EndsWith("?")){
            return "Calm down, I know what I'm doing!";
        }
    return "Whoa, chill out!";
    }
    else if(message.EndsWith("?")){
        return "Sure.";
    }
    else{
        return "Whatever.";
      }
    }
}
