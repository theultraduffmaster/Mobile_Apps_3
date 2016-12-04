# Guess The Footballer
## C-Sharp App
### Declan Duffy, G00318025

## The App
This quiz app is designed to test your variable knowledge on the various football teams that are currently in the Premiership. A certain amount of questions per team and highscore overall between all teams. Test your knowledge and earn the highest amount of points. The app is made using MVVM to optimize visualness of the app.

## History of the App
Over the course of making this app several issues were encountered including the JSON being too big to parse which was solved through async and await methods as well as when one quiz was completed they would move up the stack no longer correlating to the team the quiz was based on but this was solved by replaced stack panel with canvas and setting absolute positions for each button. An unknown deployment error was also encountered where win10{} had to be added to the JSON.Project file in order to allow the app to run. All these issues have been solved now but they lead to a time crunch and some functionality being reduced - Originally I wanted more questions per team to be parsed in to make for a longer more enjoyable quiz. Plus an even bigger JSON file might have caused previous issues to resurface.
