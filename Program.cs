using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpNoel
{
    class mob
    {
        public string name;
        public int mobHealth;
        public int mobPower;
        public int giveXp;
        public int givePo;
        public string mobAction;
        //méthode :
        //ennemie tuto : 
        public void PNS()
        {
            name = "Pére noël sombre";
            mobHealth = 500;
            mobPower = 9;
            giveXp = 100;
            givePo = 0;
            mobAction = "coup de sapin";
        }
        public void abc()
        {
            name = "test";
            mobHealth = 100;
            mobPower = 5;
            giveXp = 95;
            givePo = 10;
            mobAction = "coup de sac";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //instanciation de la class mob je le fais tout en haut pour éviter tout problèmes 
            mob mobs = new mob();

            //Déclaration des variables pour le début de la partie 
            bool userInfoStarting = false;
            string startGame = "";
            //déclaration des variables pour les diverse informations (stats/profil/money)
            int xp = 0; //xp du joueur a chaque fois que l'xp atteint 100 le joueur passera un niveau
            int level = 1; // level du joueur ( plus il sera haut mieux ses stats seront élevé)
            int health = 10; // vie du joueur
            int maxHealth = 10;// nombre maximal de pv que peut avoir le joueur (augmente avec les niveau) 
            int stamina = 100; //endurance du joueur 
            int power = 1; //puissance du joueur (permet de faire plus ou moins de dégats 
            int money = 1; //argent du joueur pourra être utilisé 
            int round = 0; // Pour affiché le nombre de tour dans le combat 
            int weaponId = 1; //id de l'arme en notre possesion dont les infos sont dans le tableau 
            // int healthMob;
            // int powerMob;
            // int giveXp;
            // int givePo;
            string username = "";
            string gender = "";
            string duelAction = "Action disponible : Attaquer(lettre \"a\") se soigner(lettre \"h\") se reposer(lettre \"d\")";
            string actionOn = "";
            //déclaration du tableau contenant toute les armes disponibles (probablement changer dans le futur par une class weapon 
            string[,] weapon = new string[,]
            {
                {"name","powerMore","healthMore"},
                {"poing","0","0"},//arme de base quand on arrive dans le jeu
                {"épée en plastique","4","10" }//arme obtenue aprés le combat tuto
            };
            //déclaration de la fonction showProfil qu'on réutilisera pour tout les cbt etc ...
            void showProfil() //déclaration de la fonction showProfil qu'on réutilisera pour tout les cbt etc ...
            {
                Console.WriteLine("Information sur votre personnage");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(username);
                Console.SetCursorPosition(1, 3);
                Console.WriteLine("Vie : " + health);
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("endurance : " + stamina);
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("puissance : " + power);
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("PO : " + money + "  XP : " + xp + "/100  level : " + level);
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("Votre arme : " + weapon[weaponId, 0]);
            }
            //déclaration de la fonction permettant d'affiché les informations sur les ennemis 
            void showMob()
            {

                Console.SetCursorPosition(76, 0);
                Console.WriteLine("Information sur votre ennemie");
                Console.SetCursorPosition(79, 2);
                Console.WriteLine(mobs.name);//nom du mob
                Console.SetCursorPosition(77, 3);
                Console.WriteLine("Vie : " + mobs.mobHealth); //vie du mob
                Console.SetCursorPosition(77, 4);
                Console.WriteLine("Puissance : " + mobs.mobPower); //puissance du mob
                Console.SetCursorPosition(77, 5);
                Console.WriteLine("gain d'xp : " + mobs.giveXp + "xp"); //gain d'xp a la fin du combat 
                Console.SetCursorPosition(77, 6);
                Console.WriteLine("gain d'or : " + mobs.givePo + "PO"); //gain en po a la fin du combat 
                Console.SetCursorPosition(77, 7);
                Console.WriteLine("attaque principal : " + mobs.mobAction); //attaque de base du monstre 
            }
            //partie visible au lancement du jeu
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenue dans le idle RPG noëlWorld");
            Console.WriteLine("On va commencer par créer votre personnage \n\r");
            Console.ResetColor();
            while (!userInfoStarting)
            {
                Console.Write("Comment vous appelez vous ? ");
                username = Console.ReadLine();
                Console.Write("êtes vous un homme ou une femme? (histoire alternative) : ");
                gender = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                if (gender == "femme")
                {
                    Console.WriteLine("êtes vous bien " + username + " et vous êtes une " + gender + "?");
                    Console.ResetColor();
                    Console.Write("oui/non : ");
                    startGame = Console.ReadLine();
                }
                else if (gender == "homme")
                {
                    Console.WriteLine("êtes vous bien " + username + " et vous êtes un " + gender + "?");
                    Console.ResetColor();
                    Console.Write("oui/non : ");
                    startGame = Console.ReadLine();
                }
                if (startGame == "oui")
                {
                    userInfoStarting = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            };

            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Bienvenue dans le monde noël");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("Vous allez affronter votre premiere enemies le fameux pére noël noir (combat tuto)");
            //on va instancier un bool qu'on utilisera pour les while
            bool startBattle = false;
            while (!startBattle)
            {
                Console.Write("êtes vous prêt? (oui/non) ");
                startGame = Console.ReadLine();
                if (startGame == "oui")
                {
                    Console.Clear();
                    startBattle = true;

                }
                else
                {
                    Console.Clear();
                    Console.Write("Vous n'avez pas du bien comprendre ^^ ");
                }
            }
            mobs.PNS();
            showProfil();
            showMob();
            Console.WriteLine(" \n\r Le combat est sur le point de commencer ");
            Console.WriteLine("dans un combat vous avez plusieurs action possible elles sont listé si dessous. \n\r Dans ce combat on va commencer par attaquer");

            startBattle = false;
            while (!startBattle)
            {
                Console.WriteLine(duelAction);
                Console.Write("Votre action : ");
                actionOn = Console.ReadLine();
                if (actionOn == "a")
                {
                    int realPower = power + int.Parse(weapon[weaponId, 1]);
                    Console.Clear();
                    mobs.mobHealth = mobs.mobHealth - realPower;
                    stamina = stamina - 90;
                    showProfil();
                    showMob();
                    if (gender == "femme")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\r Vous courrez droit vers " + mobs.name + ", vous trouvant trés jolie il ne vous attaque pas");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\r Vous courrez droit vers " + mobs.name + " face a votre bravour il vous laisse faire et ne vous attaque pas");
                        Console.ResetColor();
                    }
                    startBattle = true;  
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\r Vous avez infligé " + realPower + " dégats au pére noël sombre");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\r Vous avez perdu 90 points d'endurance car vous avez courru ..");
                    Console.ResetColor();
                    Console.WriteLine("\n\r Dans un combat vous perdez de l'endurance quand vous attaquez et quand vous vous soignez");
                }
            }
            startBattle = false;
            while (!startBattle)
            {
                Console.WriteLine("\n\r pour le prochain tour on vous conseille de vous reposer ..");
                Console.WriteLine(duelAction);
                Console.Write("Votre action : ");
                actionOn = Console.ReadLine();
                if (actionOn == "d")
                {
                    Console.Clear();
                    health = health - mobs.mobPower;
                    stamina = 100;
                    showProfil();
                    showMob();
                    if (gender == "femme")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Le" + mobs.name + "Vous a vue dormir et en profité il n'a pu résisté a votre beauté mais n'étant pas doué il vous a blessé et réveillé ...");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\r Le" + mobs.name + "Vous a vue dormir et décide de se venger avec une petite claque");
                        Console.ResetColor();
                    }
                    if(health <= 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\r Vous avez perdu 90 points d'endurance car vous avez courru ..");
                        Console.ResetColor();
                    }
                    startBattle = true;                  
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\r Vous avez récupérer la totalité de votre endurance ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\r Le " + mobs.name + "Vous a infligé " + mobs.mobPower + "Dégats");
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous êtes trop épuisé pour effectuer cette action");
                    Console.ResetColor();

                }
            }
        }
    }
}
