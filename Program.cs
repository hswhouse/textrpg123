using System.Reflection.Metadata;

namespace TextRpg
{
    internal class Program
    {
        static player user = new player();


        class player
        {
            public string playername ;
            public int level = 0;
            public string job = "전사";
            public int atk = 10;
            public int def = 5;
            public int hp = 100;
            public int gold = 1500;

            /*
            public int[] haveitem;
            //haveitem  번호로 접근한다. item 에 접근해서 가지고 있는 아이템만 가져온다.
            */
        }

        
        class item
        {
            public int id { get; set; }
            public string name { get; set; }
            public int type { get; set; } //0 은 방어력, 1은 공격력
            public int stats { get; set; }
            public string info { get; set; }
            public int price { get; set; }
            public bool haveitem { get; set; }
            public bool equipitem { get; set; }
        }

        public int[] defitemnum;

        public int[] atkitemnum;



        static void Main()
        {
            int behaviornum;
            if (user.playername == null)
            {
                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해 주세요.");
                user.playername = Console.ReadLine();

                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine("\n");
                Console.WriteLine("1. 상태보기 \n2. 인벤토리 \n3. 상점");
                Console.WriteLine("\n");
                Console.WriteLine("원하시는 행동을 입력해 주세요");

                behaviornum = int.Parse(Console.ReadLine());
                behavior(behaviornum);
            }

            else
            {
                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine("\n");
                Console.WriteLine("1. 상태보기 \n2. 인벤토리 \n3. 상점");
                Console.WriteLine("\n");
                Console.WriteLine("원하시는 행동을 입력해 주세요");

                behaviornum = int.Parse(Console.ReadLine());
                behavior(behaviornum);
            }
        }

        static void behavior(int behaviornum)
        {

            if (behaviornum == 1)
            {
                //상태 보기
                statusWindow();
            }
            else if (behaviornum == 2)
            {
                //인벤토리
                inventory();
            }
            else if (behaviornum == 3)
            {
                //상점
                shop();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다. 다시 숫자를 입력해 주세요");
                behaviornum = int.Parse(Console.ReadLine());
                behavior(behaviornum);
            }
        }

        static void statusWindow()
        {

            Console.WriteLine( user.playername + "님의 정보");
            Console.WriteLine("Lv. "+user.level);
            Console.WriteLine("chad"+user.job);
            Console.WriteLine("공격력 :"+user.atk);
            Console.WriteLine("체  력 :" + user.hp);
            Console.WriteLine("Gold :" + user.gold+"G");

            Console.WriteLine("0. 나가기");

            int behaviornum = int.Parse(Console.ReadLine());
            if (behaviornum == 0)
            {
                Main();
            }
        }

        static void inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("0. 나가기");

            int behaviornum = int.Parse(Console.ReadLine());
            if (behaviornum == 0)
            {
                Main();
            }

        }

        static void shop()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");


            item[] items = new item[6];

            //items[0] = new item(0,"수련자 갑옷",0,5,"수련에 도움을 주는 갑옷입니다",1000,false,false);
            item def0 = new item();
            def0.name = "수련자 갑옷";
            def0.type = 0;
            def0.stats = 5;
            def0.info = "수련에 도움을 주는 갑옷입니다.";
            def0.price = 1000;
            def0.haveitem = false;
            def0.equipitem = false;
            //linq 사용 c# 에서 쿼리문을 사용하게 해줌(배열이나 리스트에서 탐색을 쉽게)
            //아직 사용 안함

            item def1 = new item();

            def1.name = "무쇠갑옷";
            def1.type = 0;
            def1.stats = 5;
            def1.info = "무쇠로 만들어져 튼튼한 갑옷입니다..";
            def1.price = 1000;
            def1.haveitem = false;
            def1.equipitem = false;

            item def2 = new item();

            def2.name = "스파르타의 갑옷";
            def2.type = 0;
            def2.stats = 5;
            def2.info = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            def2.price = 1000;
            def2.haveitem = false;
            def2.equipitem = false;

            item atk0 = new item();

            atk0.name = "낡은 검";
            atk0.type = 0;
            atk0.stats = 5;
            atk0.info = "쉽게 볼 수 있는 낡은 검 입니다.";
            atk0.price = 1000;
            atk0.haveitem = false;
            atk0.equipitem = false;

            item atk1 = new item();

            atk1.name = "청동 도끼";
            atk1.type = 0;
            atk1.stats = 5;
            atk1.info = "어디선가 사용됐던거 같은 도끼입니다.";
            atk1.price = 1000;
            atk1.haveitem = false;
            atk1.equipitem = false;

            item atk2 = new item();

            atk2.name = "스파르타의 창";
            atk2.type = 0;
            atk2.stats = 5;
            atk2.info = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            atk2.price = 1000;
            atk2.haveitem = false;
            atk2.equipitem = false;

            for (int i = 0; i < 6; i++) 
            {
                if (i == 0) { }
            }


            Console.WriteLine("0. 나가기");

            int behaviornum = int.Parse(Console.ReadLine());
            if (behaviornum == 0)
            {
                Main();
            }

        }

    }
}
