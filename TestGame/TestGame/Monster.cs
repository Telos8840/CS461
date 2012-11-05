using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGame
{
    //Task currentTask;
    //State currentState;
    //ArrayList<Task> tasks = [];

    class Monster
    {
        private enum monster_attr
        {
            health,
            mana,
            item,
            play_item,
            equip,
            name,
            id
            //poop?!
        }

        public class monster
        {
            //
        }
        public class poop
        {
            //TODO: I.      Get the current location
            //      II.     If the status is Hunger > 90%
            //      III.    Create a poop object
            //      IV.     Draw the Poop X+1 Y+1?
            //      V.      Call the computer sprite random movement function on the monster
            //      VI.     Notify the poop alert?!
        }
        public class fight
        {
            //TODO:         Implementing this action later ::FIGHT 
        }
        public class eat
        {
            //TODO: I.      Get the current location
            //      II.     If the status is Hunger < 50%
            //      III.    Alert the Hunger emtion
            //      IV.     If item[food] appears on the grid then Move the monster to the food else status hunger - 5% per hr?
            //      V.      Draw eat food
            //      VI.     status hunger + 10%?
        }
        //public class hunger
        //{
        //    TODO:         Should this action be in here or in status class?!
        //}
        public class death
        {
            //TODO:         Death class has many dependency so we need to talk about this too!
        }

        public class play
        {
            //TODO:  I.     Check to see if there is an play_item[ball] on the grid         
            //       II.    3D implementation?!
        }
        public class update
        {
        //    if(tasks.count == 0)
        //        continueWalk = true;
        //    else if (boolean && currentState == wait)
        //        break;
        //    else{
        //        continueWalk = false;
        //        currentState = go;
        //    }
        }
        public class createTask(Task task)
        {
            //for (int i = 0; i < task.length ; i++){
            //    if (task[i].priority < object.priority)
            //    {
            //        task.add(object , i);
            //        i = task.length;
            //    }
            //}
        }
    }
}
