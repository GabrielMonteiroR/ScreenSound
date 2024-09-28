using ScreenSound;

Music musicOne = new Music();
Music musicTwo = new Music();


musicOne.Name = "Musica 1";
musicOne.Author = "Autor 1";    
musicOne.Duration = 3.5;        
musicOne.IsAvaliable = true;   


musicTwo.Name = "Musica 2";
musicTwo.Author = "Autor 2";    
musicTwo.Duration = 4.2;       
musicTwo.IsAvaliable = false;

//musicOne.ShowMusic();
//musicTwo.ShowMusic();

Album album = new Album();
album.Name = "Album One";
album.AddMusic(musicOne);
album.AddMusic(musicTwo);

album.ShowMusics(album);

