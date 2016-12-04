# Guess The Footballer
## C-Sharp App
### Declan Duffy, G00318025

## The App
This quiz app is designed to test your variable knowledge on the various football teams that are currently in the Premiership. A certain amount of questions per team and highscore overall between all teams. Test your knowledge and earn the highest amount of points. The app is made using MVVM to optimize visualness of the app.

## History of the App
Over the course of making this app several issues were encountered including the JSON being too big to parse which was solved through async and await methods as well as when one quiz was completed they would move up the stack no longer correlating to the team the quiz was based on but this was solved by replaced stack panel with canvas and setting absolute positions for each button. An unknown deployment error was also encountered where win10{} had to be added to the JSON.Project file in order to allow the app to run. All these issues have been solved now but they lead to a time crunch and some functionality being reduced - Originally I wanted more questions per team to be parsed in to make for a longer more enjoyable quiz. Plus an even bigger JSON file might have caused previous issues to resurface.

##User guide
To use this app just start the app and on the first page there are several buttons for several quizes all based around a specific team (denoted by both their position and colours on the button). One a quiz is chosen answer the question and if you rae right your score will go up otherwise it won't budge at all. Once all the questions are answered a new game button will appear allowing the player to start again.

##References
MVVM style adapted from code shown in doglist example in class lab2 - JSON Parsing lab - https://learnonline.gmit.ie/pluginfile.php/153102/mod_resource/content/0/LAB2-Problems.pdf
