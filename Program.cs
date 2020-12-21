using System;

namespace Debbuging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Debugging is aprocess of finding the bug that exists and finding the reason why it exists,to isolate teh code that triggers him/

            // Debugging is the process of finding the bug and fixing it in a computer program. !.
            // The instrument debugger helps us to isolate t he code where the Bug is and to fix it .
            //  if we fix one bug another one can apperas 
            // sometimes two different problems can lead to one Bug. Then we have to fix the both of the thing to fix the Bug. 
            // one the bug is fixed the we make again a unit test -called regrestion test !
            // regression test is always written after we fix a Bug !  Regression test validates , checks , that the same bug will not
            // appear again !
            // Testing and debugging are different things !
            // We always do a testing, when we write aunit tests..
            // The testing does not suppose bug existing !
            // Testing means initial detecting of the bugs !
            // Debbuging is the process  of diagnosing and correcting the root causes of errors, that we  have already been detected !
            // the testing can give infomation, c an prove bug existing.
            // the Debbugging--means that we alredy know that we have a problem bug and we are looking to loacte where it is, and the reason.
            // Perfect code is illlusion, bug free code is non existing!
            // Debugging suggests we to know or make a decision tree;
            // Decision tree- > we know the problem-we know some possible reasons that arrises him. One by one we exclude each bug reason when we
            //fix the bug
            // mostly bugs come form or ae found from QA team or the end client !
            // how to reduce the Bugs : Less code -> les Bugs !
            // keep the things simple ! no complexity ! /Reduce the complexity !
            // Bugs come from this that we have not think of all the cases !
            // understand the size of input and output data !
            // unit test  TDD of the inportant thing with 100 % code coverage !
            // always assume that the code does not works ! by design the code containg bugs .
            // unit tests help us the testing to become automatically and repeatable !
            // Debugging give us a change into a given moment to see the current state of the process , the current values 
            // breakPoints-- give us an option to stop the execution of the code !

            int x = 10;
            if (x > 10)
            {
                Console.WriteLine(x > 10);
            }
            else
            {
                Console.WriteLine("false x <= 10");
            }

            // Tips for finding bugs !!
            // DEbugging is all about data inspection ! 
            // what are the loacal variables , what is in memory , 
            // what is the code flow;
            // in General what is the state of the process right now and how did it get there  !
            // CallStack --the sequaence of teh calling the methods in my program!
            // We find that we have a bug ->
            // then we Locate the bug !
            // we gather some data and we form a hypothesis , we have to prove disprove our hypothesis
            // We fix the Bug, we test it very carefully ! , we make a regression test for the bug !
            // We look around in the code for similar mistakes !
            // after we  locate the bug we have to form hypothesis, and to start narrow the region of the code

            // be suspicious in classes that have busg before !, check the code  that has changed recently 
            // talk to someone about the problem , 
            // take abreak from the problem !
            // usually the bugs appears into the new code, or recently changed code !
            // See the last commit with the new code written !
            // incrementally fic the bugs, We fix one thing, we test, then we fix another thing

        }
    }
}
