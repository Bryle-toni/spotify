using System;
using System.Collections.Generic;
using spotify_model;

namespace spotify_DL
{
    public class SpotifyList
    {
        public List<Song> songs = new List<Song>();

        public static Song[] GetTop10Songs(DateTime date)
        {
            if (date == new DateTime(2024, 4, 1))
            {
                return new Song[]
                {
                    new Song
                    {
                    top = "1",
                    title = "Talking To The Moon",
                    artist = "Bruno Mars",
                    album = "Doo-Wops & Hooligans",
                    songwriter = "Bruno Mars, Philip Lawrence, Ari Levine, Albert Winkler, Jeff Bhasker",
                    producer = "The Smeezingtons",
                    releaseyear = "2011",
                    lengthTime = "3:37"
                },
                new Song
                {
                    top = "2",
                    title = "You Belong With Me",
                    artist = "Taylor Swift",
                    album = "Fearless",
                    songwriter = "Taylor Swift, Liz Rose",
                    producer = "Taylor Swift, Nathan Chapman",
                    releaseyear = "2009",
                    lengthTime = "3:52"
                },
                new Song
                {
                    top = "3",
                    title = "Circles",
                    artist = "Post Malone",
                    album = "Hollywood's Bleeding",
                    songwriter = "Austin Post, Louis Bell, Adam Feeney, Kaan Gunesberk",
                    producer = "Post Malone, Louis Bell, Frank Dukes",
                    releaseyear = "2019",
                    lengthTime = "3:35"
                },
                new Song
                {
                    top = "4",
                    title = "Baby",
                    artist = "Justin Bieber",
                    album = "My World 2.0",
                    songwriter = "Justin Bieber, Christopher Stewart, Terius Nash, Christopher Bridges, Christina Milian",
                    producer = "Tricky Stewart, The-Dream",
                    releaseyear = "2010",
                    lengthTime = "3:34"
                },
                new Song
                {
                    top = "5",
                    title = "Every Breath You Take",
                    artist = "The Police",
                    album = "Synchronicity",
                    songwriter = "Sting",
                    producer = "The Police, Hugh Padgham",
                    releaseyear = "1983",
                    lengthTime = "3:56"
                },
                new Song
                {
                    top = "6",
                    title = "An Art Gallery Could Never Be As Unique As You",
                    artist = "mrld",
                    album = "An Art Gallery Could Never Be As Unique As You",
                    songwriter = "mrld, Meriel de Jesus",
                    producer = "mrld, Meriel de Jesus",
                    releaseyear = "2019",
                    lengthTime = "2:38"
                },
                new Song
                {
                    top = "7",
                    title = "Sleep Tonight",
                    artist = "December Avenue",
                    album = "December Avenue",
                    songwriter = "December Avenue",
                    producer = "December Avenue",
                    releaseyear = "2017",
                    lengthTime = "4:49"
                },
                new Song
                {
                    top = "8",
                    title = "Beauty And A Beat",
                    artist = "Justin Bieber, Nicki Minaj",
                    album = "Believe",
                    songwriter = "Max Martin, Anton Zaslavski, Savan Kotecha, Onika Maraj",
                    producer = "Max Martin, Zedd",
                    releaseyear = "2012",
                    lengthTime = "3:47"
                },
                new Song
                {
                    top = "9",
                    title = "I Like Me Better",
                    artist = "Lauv",
                    album = "I Met You When I Was 18",
                    songwriter = "Lauv, Michael Matosic",
                    producer = "Lauv",
                    releaseyear = "2017",
                    lengthTime = "3:17"
                },
                new Song
                {
                    top = "10",
                    title = "Mean It",
                    artist = "Lauv, LANY",
                    album = "How I'm Feeling",
                    songwriter = "Ari Leff, Paul Klein, Michael Matosic, Michael Pollack, John Hill, Jordan Palmer",
                    producer = "LANY, Mike Crossey, Lauv",
                    releaseyear = "2019",
                    lengthTime = "3:52"
                }
                };
            }
            else if (date == new DateTime(2024, 4, 2))
            {
                return new Song[]
                {
                    new Song
                    {
                    top = "1",
                    title = "Pantropiko",
                    artist = "BINI",
                    album = "Pantropiko",
                    songwriter = "Angelika Samantha Ortiz, Mart Sam Emmanuel",
                    producer = "Mat Olavides, Jumbo De Belen",
                    releaseyear = "2023",
                    lengthTime = "3:45"
                    },
                    new Song
                    {
                    top = "2",
                    title = "Patutunguhan",
                    artist = "Cup of Joe",
                    album = "Patutunguhan",
                    songwriter = "Raphaeli Ridao, Atonio Gabriel Fernandez, Vixen Zhaesar Gareza",
                    producer = "Shadiel Chan",
                    releaseyear = "2023",
                    lengthTime = "4:12"
                    },
                    new Song
                    {
                    top = "3",
                    title = "Tadhana",
                    artist = "Up Dharma Down",
                    album = "Tadhana",
                    songwriter = "Armi Millare, Paul Yap",
                    producer = "Up Dharma Down",
                    releaseyear = "2012",
                    lengthTime = "3:42"
                    },
                    new Song
                    {
                    top = "4",
                    title = "Mahika",
                    artist = "Adie and Janine Berdin",
                    album = "Mahika",
                    songwriter = "Adie Garcia, Janine Berdin",
                    producer = "Adie",
                    releaseyear = "2022",
                    lengthTime = "3:14"
                    },
                    new Song
                    {
                    top = "5",
                    title = "Take A Chance With Me",
                    artist = "NIKI",
                    album = "Nicole",
                    songwriter = "Nicole Zefanya",
                    producer = "NIKI",
                    releaseyear = "2022",
                    lengthTime = "5:03"
                    },
                    new Song
                    {
                    top = "6",
                    title = "Ikaw Pa Rin",
                    artist = "mrld",
                    album = "Ikaw Pa Rin",
                    songwriter = "Meriel De Jesus",
                    producer = "mrld",
                    releaseyear = "2022",
                    lengthTime = "3:11"
                    },
                    new Song
                    {
                    top = "7",
                    title = "Sinderela",
                    artist = "Cup of Joe",
                    album = "Sinderela",
                    songwriter = "Clint Fernandez, Gabriel Fernandez, Gian Bernardino",
                    producer = "Cup of Joe",
                    releaseyear = "2019",
                    lengthTime = "4:08"
                    },
                    new Song
                    {
                    top = "8",
                    title = "Ulap",
                    artist = "Rob Daniel",
                    album = "Ulap",
                    songwriter = "Rob Daniel",
                    producer = "Rob Daniel",
                    releaseyear = "2020",
                    lengthTime = "6:45"
                    },
                    new Song
                    {
                    top = "9",
                    title = "Fallen",
                    artist = "Lola Amour",
                    album = "Fallen",
                    songwriter = "Pio Antonio Benitez Dumayas",
                    producer = "Lola Amour",
                    releaseyear = "",
                    lengthTime = "3:21"
                    },
                    new Song
                    {
                    top = "10",
                    title = "Heartbreak Girl",
                    artist = "5 Seconds Of Summer",
                    album = "5 Seconds Of Summer",
                    songwriter = "Lindy Robbins, Steve Robson, Calum Hood, Luke Hemmings",
                    producer = "Steve Robson",
                    releaseyear = "2014",
                    lengthTime = "3:18"
                    },
                };
            }
            else if (date == new DateTime(2024, 4, 3))
            {
                return new Song[]
                {
                    new Song
                    {
                    top = "1",
                    title = "Daylight",
                    artist = "Maroon 5",
                    album = "Overexposed",
                    songwriter = "Adam Levine",
                    producer = "Adam Levine",
                    releaseyear = "2012",
                    lengthTime = "3:45"
                    },
                    new Song
                    {
                    top = "2",
                    title = "18",
                    artist = "5 Seconds Of Summer",
                    album = "5 Seconds Of Summer",
                    songwriter = "Ash Howes, Seton Daunt",
                    producer = "John Feldmann",
                    releaseyear = "2014",
                    lengthTime = "3:09"
                    },
                    new Song
                    {
                    top = "3",
                    title = "Getaway Car",
                    artist = "Taylor Swift",
                    album = "Reputation",
                    songwriter = "Taylor Swift",
                    producer = "Taylor Swift",
                    releaseyear = "2017",
                    lengthTime = "3:53"
                    },
                    new Song
                    {
                    top = "4",
                    title = "Strong",
                    artist = "One Direction",
                    album = "Midnight Memories",
                    songwriter = "Jamie Scott",
                    producer = "John Ryan",
                    releaseyear = "2013",
                    lengthTime = "3:04"
                    },
                    new Song
                    {
                    top = "5",
                    title = "The Story Of Us",
                    artist = "Taylor Swift",
                    album = "Speak Now",
                    songwriter = "Taylor Swift",
                    producer = "Taylor Swift",
                    releaseyear = "2010",
                    lengthTime = "4:26"
                    },
                    new Song
                    {
                    top = "6",
                    title = "Live While We're Young",
                    artist = "One Direction",
                    album = "Take Me Home",
                    songwriter = "One Direction",
                    producer = "Carl Falk",
                    releaseyear = "2012",
                    lengthTime = "3:20"
                    },
                    new Song
                    {
                    top = "7",
                    title = "Can We Dance",
                    artist = "The Vamps",
                    album = "Meet The Vamps",
                    songwriter = "The Vamps",
                    producer = "The Vamps",
                    releaseyear = "2014",
                    lengthTime = "3:12"
                    },
                    new Song
                    {
                    top = "8",
                    title = "Kiss You",
                    artist = "One Direction",
                    album = "Take Me Home",
                    songwriter = "Albin Nedler, Rami Yacoub",
                    producer = "Rami, Carl Falk",
                    releaseyear = "2012",
                    lengthTime = "3:02"
                    },
                    new Song
                    {
                    top = "9",
                    title = "Beautiful Soul",
                    artist = "Jesse McCartney",
                    album = "Beautiful Soul",
                    songwriter = "Adam Watts, Andy Dodd",
                    producer = "Greg Wells, Adam Watts",
                    releaseyear = "2004",
                    lengthTime = "3:34"
                    },
                    new Song
                    {
                    top = "10",
                    title = "She Looks So Perfect",
                    artist = "5 Seconds Of Summer",
                    album = "5 Seconds Of Summer",
                    songwriter = "Jake Sinclair, Ashton Irwin, Michael Clifford",
                    producer = "Jake Sinclair, Eric Valentine",
                    releaseyear = "2014",
                    lengthTime = "3:22"
                    },
                };
            }
            else if (date == new DateTime(2024, 4, 4))
            {
                return new Song[]
                {
                    new Song
                    {
                    top = "1",
                    title = "Oh Cecilia",
                    artist = "The Vamps",
                    album = "Meet The Vamps",
                    songwriter = "Connor Ball, James McVey, Tristan Evans",
                    producer = "Andrew Williams, Espen Lind",
                    releaseyear = "2014",
                    lengthTime = "3:16"
                    },
                    new Song
                    {
                    top = "2",
                    title = "One Thing",
                    artist = "One Direction",
                    album = "Up All Night",
                    songwriter = "Carl Falk, Savan Kotecha",
                    producer = "Rami Yacoub, Carl Falk",
                    releaseyear = "2012",
                    lengthTime = "3:17"
                    },
                    new Song
                    {
                    top = "3",
                    title = "Love Somebody",
                    artist = "Maroon 5",
                    album = "Overexposed",
                    songwriter = "Adam Levine",
                    producer = "Ryan Tedder",
                    releaseyear = "2012",
                    lengthTime = "3:49"
                    },
                    new Song
                    {
                    top = "4",
                    title = "They Don't Know About Us",
                    artist = "One Direction",
                    album = "Take Me Home",
                    songwriter = "Peter Wallvik, Tebey Ottoh",
                    producer = "Tebey Ottoh, Julian Bunetta",
                    releaseyear = "2012",
                    lengthTime = "3:20"
                    },
                    new Song
                    {
                    top = "5",
                    title = "Fall for you",
                    artist = "Secondhand Serenade",
                    album = "A twist in my story",
                    songwriter = "John Vesely",
                    producer = "Danny Lohner",
                    releaseyear = "2008",
                    lengthTime = "3:03"
                    },
                    new Song
                    {
                    top = "6",
                    title = "Won't Go Home Without You",
                    artist = "Maroon 5",
                    album = "It won't be soon before long",
                    songwriter = "Adam Levine",
                    producer = "Mike ELizondo, Maroon 5",
                    releaseyear = "2007",
                    lengthTime = "3:51"
                    },
                    new Song
                    {
                    top = "7",
                    title = "Tonight",
                    artist = "FM Static",
                    album = "Critically Ashamed",
                    songwriter = "Steve Augustine, Trevor McNevan",
                    producer = "Trevor McNevan",
                    releaseyear = "2006",
                    lengthTime = "3:38"
                    },
                    new Song
                    {
                    top = "8",
                    title = "Teenagers",
                    artist = "My Chemical Romance",
                    album = "The Black Parade",
                    songwriter = "Frank Lero, Gerard Way",
                    producer = "Frank Lero, Gerard Way",
                    releaseyear = "2006",
                    lengthTime = "2:41"
                    },
                    new Song
                    {
                    top = "9",
                    title = "You Belong With Me",
                    artist = "Taylor Swift",
                    album = "Fearless",
                    songwriter = "Liz Rose, Taylor Swift",
                    producer = "Taylor Swift",
                    releaseyear = "2021",
                    lengthTime = "3:52"
                    },
                    new Song
                    {
                    top = "10",
                    title = "Baby Blue Eyes",
                    artist = "A Rocket To The Moon",
                    album = "On Your Side",
                    songwriter = "Andrew Cook, Eric Halvorsen",
                    producer = "A rocket to the moon, Matt Squire",
                    releaseyear = "2009",
                    lengthTime = "3:40"
                    },
                };
            }
            else if (date == new DateTime(2024, 4, 5))
            {
                return new Song[]
                {
                    new Song
                    {
                    top = "1",
                    title = "Wish you were here",
                    artist = "Avril Lavigne",
                    album = "Goodbye Lullaby",
                    songwriter = "Max Martin, Avril Lavigne, Shellback",
                    producer = "Shellback, Max Martin",
                    releaseyear = "2011",
                    lengthTime = "3:45"
                    },
                    new Song
                    {
                    top = "2",
                    title = "The Story of Us",
                    artist = "Taylor Swift",
                    album = "Fearless",
                    songwriter = "Taylor Swift",
                    producer = "Taylor Swift",
                    releaseyear = "2021",
                    lengthTime = "4:26"
                    },
                    new Song
                    {
                    top = "3",
                    title = "The Man Who Can't Be Moved",
                    artist = "The Script",
                    album = "The Script",
                    songwriter = "Andrew Frampton, Mark Sheehan",
                    producer = "Andrew Frampton, Steve Kipner",
                    releaseyear = "2008",
                    lengthTime = "4:01"
                    },
                    new Song
                    {
                    top = "4",
                    title = "Apologize",
                    artist = "OneRepublic",
                    album = "Dreaming Out Loud",
                    songwriter = "Ryan Tedder",
                    producer = "Greg Wells, Ryan Tedder",
                    releaseyear = "2007",
                    lengthTime = "3:28"
                    },
                    new Song
                    {
                    top = "5",
                    title = "Perfect",
                    artist = "Simple Plan",
                    album = "No Pads, No Helmet....Just Balls",
                    songwriter = "Arnold Lanni, Chuck Comeau",
                    producer = "Arnold Lanni",
                    releaseyear = "2002",
                    lengthTime = "4:37"
                    },
                    new Song
                    {
                    top = "6",
                    title = "Malibu Nights",
                    artist = "LANY",
                    album = "Malibu Nights",
                    songwriter = "Paul Jason Klein",
                    producer = "LANY",
                    releaseyear = "2018",
                    lengthTime = "4:46"
                    },
                    new Song
                    {
                    top = "7",
                    title = "Dear Maria, Count Me In",
                    artist = "All time low",
                    album = "So wrong, it's right",
                    songwriter = "Jack Barakat",
                    producer = "Matt Squire",
                    releaseyear = "2007",
                    lengthTime = "3:02"
                    },
                    new Song
                    {
                    top = "8",
                    title = "Puppy Love",
                    artist = "This Wild Life",
                    album = "Puppy Love",
                    songwriter = "This Wild Life",
                    producer = "This Wild Life",
                    releaseyear = "2012",
                    lengthTime = "2:40"
                    },
                    new Song
                    {
                    top = "9",
                    title = "Fireflies",
                    artist = "Owl City",
                    album = "Ocean Eyes",
                    songwriter = "Adam Young",
                    producer = "Adam Young",
                    releaseyear = "2009",
                    lengthTime = "3:48"
                    },
                    new Song
                    {
                    top = "10",
                    title = "Mine",
                    artist = "Taylor Swift",
                    album = "Speak Now",
                    songwriter = "Taylor Swift",
                    producer = "Taylor Swift, Nathan Chapman",
                    releaseyear = "2010",
                    lengthTime = "3:50"
                    },
                };

            }
            else
            {
                return new Song[0];
            }
        }
    }
}