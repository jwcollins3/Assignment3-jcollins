using Tweetinvi.Core.Injectinvi;

namespace Assignment3_jcollins.Models
{
    public class ActorDetailVM
    {
            public Actor actor { get; set; }
            public List<ActorTweet>? Tweets { get; set; }
            public double AverageTweetSentiment()
            {
                if (Tweets == null) return 0;
                int validTweets = 0;
                double totalTweetScore = 0;
                foreach (ActorTweet tweet in Tweets)
                {
                    if (tweet.Sentiment != 0)
                    {
                        validTweets++;
                        totalTweetScore += tweet.Sentiment;
                    }
                }
                return totalTweetScore / validTweets;
            }
    }
}
