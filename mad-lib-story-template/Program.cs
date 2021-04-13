using System;

namespace mad_lib_story_template
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Declaring and initializing a string var in one step!

            string adj1 = "goey";
            string adj2 = "purple";
            string adj3 = "large";
            string adj4 = "invisible";
            string noun1 = "car";
            string noun2 = "mountain";
            string noun3 = "guitar";
            string pastVerb1 = "swam";
            string pastVerb2 = "teleported";
            string adverb1 = "lavishly";
            string adverb2 = "mysteriously";
            string verb = "fly";

            
            //interpolation

            Console.WriteLine($"Today I went to the zoo. I saw a {adj1} {noun1} jumping up and down in its tree. He {pastVerb1} {adverb1} through the large tunnel that lead to its {adj2} {noun2}. I got some peanuts and passed them through the cage to the gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adj3} scoop of ice cream. It filled my stomach. Afterwards I had to {verb} {adverb2} to catch our bus. When I got home I {pastVerb2} my mom for a {adj4} day at the zoo.");


            //This will keep the Console open.  KEEP THIS OPEN SO IT DOESN'T JUST FLASH!!!
            Console.ReadLine();
        }
    }
}
