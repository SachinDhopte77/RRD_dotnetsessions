using HumanCommanLib.Models;

namespace HumanCommanLib.Exceptions
{

    public class Notallowedtoworkout : Exception
    {
        private Human _human;

        public Notallowedtoworkout(Human human)
        {
            _human = human;
        }

        public override string Message
        {
            get { return $"Name : {_human.Name} : Your age is {_human.Age} You are not allowed to workout."; }
        }

    }
}