using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Project1;
public class Olympics {
	public static List<Participant>? participants;

	public static List<Participant> ReadParticipants(string fname) {
		participants = new List<Participant>();
		using (StreamReader input = new StreamReader(fname)) {
			string? header = input.ReadLine();  // Read and discard the header
			while (!input.EndOfStream) {
				string? line = input.ReadLine();
				if (line == null) {
					continue;
				}
				Participant p = new Participant(line);
				participants.Add(p);
			}
		}
		return participants;
	}

	
	public static void Main(string[] args) {
		ReadParticipants("olympics.tsv");

		while (true) {
			Console.Write(">> ");
			string? userInput = Console.ReadLine();
			string[] userWords = userInput.Split(new char[] { ' ' });
			if (userInput == "hosts")
			{ //Hosts
				List<String> uniqueLocations = new List<string> { };
				for (int i = 0; i < participants.Count; i++)
				{
					if (!uniqueLocations.Contains(participants[i].Location))
					{
						uniqueLocations.Add(participants[i].Location);
					}
				}
				uniqueLocations.Sort();
				foreach (var location in uniqueLocations)
				{
					Console.WriteLine(location);
				}
			}
			else if (userWords[0] == "count")
			{
				int count = 0;
                String country = countryValidation(userWords);
                for (int i = 0; i < participants.Count; i++)
				{
					//Console.WriteLine(userWords[1]);
					if (participants[i].Year.ToString() == userWords[1] && participants[i].Country == country)
					{
						if (participants[i].Medal != Participant.MedalType.None)
						{
							count++;
						}
					}
				}
				Console.WriteLine(count);
			}
			else if (userWords[0] == "golds")
			{
				String country = countryValidation(userWords);
                int count = 0;
                for (int i = 0; i < participants.Count; i++)
                {

                    if (participants[i].Year.ToString() == userWords[1] && participants[i].Country == country)
                    {
                        if (participants[i].Medal == Participant.MedalType.Gold)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);
            } else if (userWords[0] == "podium")
			{
                int year = int.Parse(userWords[1]);
                String season = userWords[2];
				string Event = eventValidation(userWords);
				//List<string> medalists = new List<string> { };
				List <List<string>> medalists = new List<List<string>>();
                List<string> Gold = new List<string>();
                List<string> Silver = new List<string>();
                List<string> Bronze = new List<string>();


				medalists.Add(Gold);
                medalists.Add(Silver);
                medalists.Add(Bronze);
                for (int i = 0; i < participants.Count; i++)
				{
					if (participants[i].Year == year && participants[i].Season.ToString() == season && participants[i].Event == Event)
					{
						if (participants[i].Medal == Participant.MedalType.Gold)
						{
							medalists[0].Add(participants[i].Name);
                        }
                        if (participants[i].Medal == Participant.MedalType.Silver)
                        {
                            medalists[1].Add(participants[i].Name);
                        }
                        if (participants[i].Medal == Participant.MedalType.Bronze)
                        {
                            medalists[2].Add(participants[i].Name);
                        }

                    }
                }
                Console.Write("Gold : ");
                print(medalists[0]);
                Console.Write("Silver : ");
                print(medalists[1]);
                Console.Write("Bronze : ");
                print(medalists[2]);


            } else if (userWords[0] == "exit")
			{
				return;
			} else
			{
				Console.WriteLine("Please enter one of the commands: " +
					"hosts,count,golds,podium or exit");
			}
		}
	}

	public static String countryValidation(string[] userWords)
	{
		String str = userWords[0];
		for (int j = 2; j < userWords.Length; j++)
		{
			if (j == 2) { str = userWords[2]; }
			else
			{
				str += " " + userWords[j];
			}
			for (int i = 0; i < participants.Count; i++)
			{
				if (participants[i].Country == str)
				{
					//Console.WriteLine("Country Found");
					return str; // Country found. Continue
				}

			}
		}
		//Console.WriteLine("Country not Found");
		return str;
	}

    public static String eventValidation(string[] userWords)
    {
        String str = userWords[3];
        for (int j = 3; j < userWords.Length; j++)
        {
            if (j == 3) { str = userWords[3]; }
            else
            {
                str += " " + userWords[j];
            }
            for (int i = 0; i < participants.Count; i++)
            {
                if (participants[i].Event == str)
                {
                    Console.WriteLine("Event Found");
                    return str; // Country found. Continue
                }

            }
        }
        Console.WriteLine("Event not Found");
        return str;
    }

	public static void print(List<string> str)
	{
		foreach(string element in str)
		{
			Console.WriteLine(element);
		}
	}

}