using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTutorial
{
    [Binding]
    public class OrderingAnswersSteps {

    

        private QuestionModel q;
    
        [Given(@"There is a question ""(.*)"" with the answers")]
        public void GivenThereIsAQuestionWithTheAnswers(string p0, Table table)
        {
            q = new QuestionModel();
            q.question = p0;
            foreach (var row in table.Rows) 
            {
                q.answers.Add(row["Answer"], Int32.Parse(row["Vote"]));
            }
            
    
        }

        [When(@"you upvote the answer ""(.*)""")]
public void WhenYouUpvoteTheAnswer(string p0)
{
    q.upvote(p0);
}

        [Then(@"the answer ""(.*)"" should be on top")]
public void ThenTheAnswerShouldBeOnTop(string p0)
{
    Assert.AreEqual("Cucumber Green", q.TopAnswer());
}
    }


    public class QuestionModel
    {
        public string question { get; set; }
        public Dictionary<string, int> answers { get; set; }

        public QuestionModel()
        {
            answers = new Dictionary<string, int>();
        }

        public void upvote(string answer)
        {
            answers[answer] += 1;
        }

        public string TopAnswer()
        {
            var sortedAnswers = from pair in answers
                                orderby pair.Value descending
                                select pair;
            return sortedAnswers.First().Key;
        }
    }

    

}
