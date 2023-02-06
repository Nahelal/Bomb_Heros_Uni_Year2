# COMP260 Distributed Systems: Artifact Technical Report
#### Word count: 

## Artifact outline

With recent global events forcing us to be more active online for regular things such as social interaction and entertainment, there has been a massive surge in online multiplayer casual games such as among us __[4]__ and fall guys __[3]__. Engaging with multiplayer games during times such as over covid-19 was allowing people to connect to others all over the world and build friendships that wouldn't have otherwise been possible, whilst also taking away the stress of real life for a short time, ultimately improving mood and wellbeing. 

These types of casual multiplayer games are not slowing down any time soon either, with the market being valued at $56 billion in 2021 and estimated to hit $132 billion by 2030 __[5]__. This suggests that more and more people are going to start playing this genre of casual games and ultimately find potential benefits and stress relief through this mode of entertainment.

Knowing this, I aim to look into the affect of casual gaming on reducing stress and improving mood by researching into multiple studies and conducting my own research through the form of a brief questionnaire using the 'nine-item Psychological Stress Measure' (PSM-9). The PSM-9 is used to measure levels of stress from the last 4-5 days and was used in similar studies such as by *Veeral Desai et al* __[2]__ before and after the study took place. 

![image](https://media.github.falmouth.ac.uk/user/730/files/84b96105-ee7f-4653-b227-e268a57c2dc3)

*Fig 1, screenshot showing an example of the PSM-9*

In order to test this, My artifact is going to be based around the 2007 game 'Bomb it' __[1]__  with an added networking aspect to make the game online multiplayer instead of local multiplayer so it also fits into my distributed systems module. The project is going to be a casual 2-4 player game, where the last player alive wins. The game premise involves collecting upgrades and moving around a 2d top-down map, where the player is placing bombs in order to destroy walls and reach the other players to eliminate them. 

![image](https://media.github.falmouth.ac.uk/user/730/files/433bc46d-3e79-4117-9d75-f6ba6a7469bd)

*Fig 2, screenshot of gameplay from the game 'Bomb it'*

I am also going to include a player login, where the player uses a username and password in order to login and access their account to play the game, which will also fit into my specialist module. The user data is going to be stored on a database which will have both the usernames and passwords of users stored on it to verify the account information during login. There would also need to be a game manager which runs the game on a server and also has the ability to manage, create, and destroy a game session.

In order to implement this in my project, I am going to use unity which uses c# to create my game. This is due to the fact that Unreal Engine 5 has integrated multiplayer services which would reduce the complexity of my project. Additionally, in order to keep my artifact in the category of a casual game, I need to ensure my final project is short to play with fast paced games, has simple controls and is easy to learn, and is also widely accessible to appeal to a mass market, to name a few. 


## Work plan

![image](https://media.github.falmouth.ac.uk/user/730/files/76609670-1d78-410b-a438-7e764d526256)

*Fig 3, screenshot of project timeline using a gantt chart (https://app.asana.com/0/1203885328471859/files
)*

Due to the short development time of 7 weeks, I am going to have to prevent overscoping by only implementing what is completely neccessary into the game, with a potential to expand upon it in the future. 

In the first three weeks of development, I will work on getting the base project for the game working by implementing all of the core mechanics I am wanting, as well as working on some of the visual elements to make it more engaging for the player. This, for example, includes getting item interaction with bombs, destroying walls, and upgrade pickup.

![image](https://media.github.falmouth.ac.uk/user/730/files/f4e1e275-5b8b-44a0-81da-66028bb91047)

*Fig 4, screenshot of class diagram briefly outlining game funtions needing to be implemented*

In the three weeks after that, I am going to work on implementing the networking aspect of the project, making it so the game is playable for up to 4 players being able to connect to a game server, and also create the login system for players to access the game and to correctly store player information in a database.

Prior to this, I am also going to have to look into unreal networking systems more extensively to ensure that the implementation of this goes as smoothly as possible when considering the short time for development. For my project, I would like to research into unitys mirror library for hosting the game server but will likely create a listen server which will use  one of the clients games as the host and have the other players connect to their hosted game.

![image](https://media.github.falmouth.ac.uk/user/730/files/4c4c8132-f706-4b3a-afba-bc9f767d6d0a)
 
 *Fig 4, screenshot of unitys mirror library for an online multiplayer game using a user login system, similar to my potential implementation (https://docs.unity.com/relay/en/manual/mirror)*

In the last week or whilst working on implementing networking features, I am going to work on my technical poster and finalising anything that is still being worked on for the artifact in time for the deadline, as outlined on the gantt chart.



## bibliography

[1] Person, AGame. “Bomb It 🕹️ Play Bomb It on CrazyGames.” 🕹️ Play Bomb It on CrazyGames, Apr. 2007, https://www.crazygames.com/game/bomb-it. 

[2] Desai, Veeral, et al. "Stress-reducing effects of playing a casual video game among undergraduate students." Trends in Psychology 29 (2021): 563-579.

[3] “Fall Guys.” Fall Guys | Season 3: Sunken Secrets, Epic Games, 4 Aug. 2020, https://www.fallguys.com/en-US. 

[4] “Among Us: Innersloth - Creators of among Us and the Henry Stickmin Collection!” Innersloth, InnerSloth LLC, 15 June 2018, https://www.innersloth.com/games/among-us/. 

[5] Balasubramanian, Karthik. “The Rise of Online Multiplayer.” Gameopedia, 30 Aug. 2022, https://www.gameopedia.com/online-multiplayer-games/#:~:text=The%20global%20online%20gaming%20market,annual%20growth%20rate%20of%2010.2%25. 




#### Other references used for research

Soft, Hudson Soft. “Bomberman (NES) - Online Game.” RetroGames.cz, Konami, July 1983, https://www.retrogames.cz/play_085-NES.php?language=EN. 

Russoniello, Carmen V., Kevin O’Brien, and Jennifer M. Parks. "The effectiveness of casual video games in improving mood and decreasing stress." Journal of CyberTherapy & Rehabilitation 2.1 (2009): 53-66.

Pallavicini, Federica, Alessandro Pepe, and Fabrizia Mantovani. "Commercial off-the-shelf video games for reducing stress and anxiety: systematic review." JMIR mental health 8.8 (2021): e28150.







