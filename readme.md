# COMP260 Distributed Systems: Artifact Technical Report
#### Word count: 

## Artifact introduction

With recent global events forcing us to be more active online for normal things such as social interaction and entertainment, there has been a surge of semi-competative games such as among us __[4]__ and fall guys __[3]__

i aim to look into the affect of casual gaming on reducing stress and improving mood by researching into multiple studies and conducting my own research through the form of a brief questionnare using the 'nine-item Psychological Stress Measure' (PSM-9). The PSM-9 is used to measure levels of stress from the last 4-5 days and was used in similar studies such as by *Veeral Desai et al* __[2]__ before and after the study took place. 
 
In order to test this, My artifact is going to be based around the 2007 game 'Bomb it' __[1]__  with an added networking aspect to make the game online multiplayer instead of local multiplayer. The project is going to be a casual 2-4 player game, where the last player alive wins. The game premise involves collecting upgrades and moving around a 2d topdown map, where the player is placing bombs in order to destroy walls and reach the other players to eliminate them. I am going to include a player login and scoring system, where the players highscores are kept on their accounts on a database and can be referenced to create a global leaderboard which gives the players an insentive to not only eliminate players, but also to collect the upgrades to improve their own score.

![image](https://media.github.falmouth.ac.uk/user/730/files/433bc46d-3e79-4117-9d75-f6ba6a7469bd)

*Fig 1, screenshot by author of gameplay from the game 'Bomb it'*

Additionally, in order to keep my artifact in the category of a casual game, i need to ensure my final project is short to play with fast paced games, has simple controls and is easy to learn, and is also widely accessable to appeal to a mass market, to name a few. 

## Specialism links

This project fits into my distributed system specialism due to the fact that i am creating an online multiplayer game which will use a log in system for the players to access and play the game. This also allows the players game scores to be stored on their account which will be accessable on any device in which they log on to with the same account. This is because the players information and scores being stored in a database which will be accessable to them when they log in. There would also need to be a game manager which runs the game on a dedicated server and also has the ability to manage, create, and destroy a game session.

In order to implement this in my project, i am going to use unity which uses c# to create my game. This is due to the fact that Unreal Engine 5 has integrated multiplayer services which would reduce the complexity of my project.

## Work plan

![image](https://media.github.falmouth.ac.uk/user/730/files/76609670-1d78-410b-a438-7e764d526256)

*Fig 2, screenshot by author of project timeline using a gantt chart (https://app.asana.com/0/1203885328471859/files
)*

Due to the short development time of 7 weeks, i am going to have to prevent overscoping by only implementing what is completely neccessary into the game, with a potential to expand upon it in the future. 

In the first three weeks of development, i will work on getting the base project for the game working by implementing all of the core mechanics i am wanting, as well as working on some of the visual elements to make it more engaging for the player. In the three weeks after that, i am going to work on implementing the networking aspect of the project, making it so the game is playable for up to 4 players and correctly stores player information and scores in a database. In the last week or so, i am going to work on my technical poster and finalising anything that is still being worked on for the artifact in time for the deadline, as outlined on the gantt chart.


# currently just under 600 words above this point

#### core game functionality requirements

> menu screens 
> visual elements- map(walls and stuff), item upgrades, bombs, player models
> 
> controls implementation for movement and placing bombs
> 
> item interaction with bombs damaging walls and item pickups 
> 
> health system for each player
> 
> player point scoring system and timer 



.


.

.

.

.


## to do 

also need academic research to back the research point up
 
 make a class or uml diagram of game concept mechanics
 
 use easybib for gray literature citations 
 
 structure of network code but also of how the game works
 
 state similar games that hit research points 
 
 5-10 citations 
 
 
 
 
 
 
 
 
need an outline of the software design and architecture
software dev life-cycle
knowledge of system architectire and strong design 
defense argument found from research
research methods, primary and secondaryt research
structure, references and stuff


What it means to be a casual gamer?
The term casual gaming refers to video games which do not require a major time investment to play, win, and enjoy. A casual gamer is a player who enjoys any video game without investing significant time to it, playing it spontaneously, irregularly, or infrequently


.

.

similar games include 'Bomberman' [2] which is what bomb it is based on. has monsters that you have to destroy rather than players. not multiplayer, although more modern versions probably are?
https://www.retrogames.cz/play_085-NES.php?language=EN



google schollar + casual video games


![image](https://media.github.falmouth.ac.uk/user/730/files/744c60a0-5a72-4a25-b4c4-ffa774f26e26)

example of the PSM-9





## bibliography

[1] Person, AGame. “Bomb It 🕹️ Play Bomb It on CrazyGames.” 🕹️ Play Bomb It on CrazyGames, Apr. 2007, https://www.crazygames.com/game/bomb-it. 

[2] Desai, Veeral, et al. "Stress-reducing effects of playing a casual video game among undergraduate students." Trends in Psychology 29 (2021): 563-579.

[3] “Fall Guys.” Fall Guys | Season 3: Sunken Secrets, Epic Games, 4 Aug. 2020, https://www.fallguys.com/en-US. 

[4] “Among Us: Innersloth - Creators of among Us and the Henry Stickmin Collection!” Innersloth, InnerSloth LLC, 15 June 2018, https://www.innersloth.com/games/among-us/. 

 Soft, Hudson Soft. “Bomberman (NES) - Online Game.” RetroGames.cz, Konami, July 1983, https://www.retrogames.cz/play_085-NES.php?language=EN. 



Russoniello, Carmen V., Kevin O’Brien, and Jennifer M. Parks. "The effectiveness of casual video games in improving mood and decreasing stress." Journal of CyberTherapy & Rehabilitation 2.1 (2009): 53-66.



Pallavicini, Federica, Alessandro Pepe, and Fabrizia Mantovani. "Commercial off-the-shelf video games for reducing stress and anxiety: systematic review." JMIR mental health 8.8 (2021): e28150.







