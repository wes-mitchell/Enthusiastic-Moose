using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

bool MooseAsks(string question)
{
    Console.WriteLine($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else 
    {
        return false;
    }
}

void MooseSays(string message)
{
      Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada Real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else 
    {
        MooseSays("I  K N E W  I T !!!");
    }
}

void EatsGerbilsQuestion()
{
    bool eatsGerbils = MooseAsks("Do you eat gerbils?");
    if (eatsGerbils)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void KoolAidManQuestion()
{
    bool knowsKoolAidMan = MooseAsks("Do you know the Kool Aid Man?");
    if (knowsKoolAidMan)
    {
        MooseSays("O H  Y E A !");
    }
    else
    {
        MooseSays("Well, dang ol boom.");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

KoolAidManQuestion();
EatsGerbilsQuestion();
}
