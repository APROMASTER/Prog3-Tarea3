// Chores list made by Ariel Nuñez 2022-0551

ChoresData.Instance.LoadData();

var MainMenu = new MainMenu();
MainMenu.Display();

ChoresData.Instance.SaveData();
