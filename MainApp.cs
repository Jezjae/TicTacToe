using System;

namespace _2DArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /* 2차배열 연습
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"{i}, {j} : {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}, {j}] : {arr2[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}, {j}] : {arr3[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */

            /* 2차배열 확인
            int[,] array = new int[3, 3]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" | [{i}, {j}] : {array[i, j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("■■■■■■■■■■");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"■ {array[i, j]}  ");
                }
                Console.WriteLine("■");

                if ( i == i )
                {
                    Console.WriteLine("■■■■■■■■■■");
                }
            }
            */


            // 3목 사용자 VS 사용자 .ver


            char[,] array = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };


            string a = ""; //탈출 문구 입력 값 (메인 or 다시시작)
            bool ischeck = true; //fales가 되면 시스템 종료
            bool ischeck2 = true; //fales가 되면 게임 종료 후 메인
            bool ischeck3 = true; //fales가 되면 게임 종료 후 게임 다시 시작
            bool ischeck4 = true; // 게임종료후 돌아가기 선택 버튼 반복
            bool ischeck5 = true; // 유저에서 이선좌 반복
            bool ischeck6 = true; // 컴이 훑었을때 이선좌 반복해서 하나 놓게 만드는 것



            //점수기록 선언
            int oVictory = 0;
            int xVictory = 0;
            int computerVictory = 0;
            int userVsCom = 0;



            while (ischeck == true) //메인화면 반복
            {
                Console.Clear();
                main(); //메인화면
                string readNum = Console.ReadLine();
                int num = Convert.ToInt32(readNum);



                if (num == 1) //유저대결
                {
                    ischeck2 = true;
                    while (ischeck2 == true)
                    {

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("'O' User VS 'X' User");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("선공할 기호를 입력하세요. ('O'선공은 '1', 'X'선공은 '2') |  입력 : ");
                        string choice = Console.ReadLine();
                        int c = Convert.ToInt32(choice);


                        if (c == 1) //유저가 o일때
                        {
                            ischeck3 = true;
                            while (ischeck3 == true) // fales가 되면 유저대결 종료 후 ischeck while문으로 돌아와 메인부터 반복
                            {
                                Console.Clear();  //초기화
                                board(); // 판보여주기

                                routineO(); //유저 O 반복
                                if (ischeck2 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                }
                                else if (ischeck3 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                }

                                routineX(); //유저 X 반복
                                if (ischeck2 == false)
                                {
                                    xVictory++;
                                    Console.Clear();
                                    break;
                                }
                                else if (ischeck3 == false)
                                {
                                    xVictory++;
                                    Console.Clear();
                                    break;
                                }
                            }
                        }
                        else if (c == 2) // 유저가 x일때
                        {
                            ischeck3 = true;
                            while (ischeck3 == true) // fales가 되면 유저대결 종료 후 ischeck while문으로 돌아와 메인부터 반복
                            {
                                Console.Clear();  //초기화
                                board(); // 판보여주기

                                routineX(); //유저 X 반복
                                if (ischeck2 == false)
                                {
                                    xVictory++;
                                    Console.Clear();
                                    break;
                                }
                                else if (ischeck3 == false)
                                {
                                    xVictory++;
                                    Console.Clear();
                                    break;
                                }

                                routineO(); //유저 O 반복
                                if (ischeck2 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                }
                                else if (ischeck3 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                }
                            }
                        }
                        else //무한 반복
                        {
                            Console.WriteLine();
                            Console.WriteLine("다시 입력해주세요 !");
                            Console.WriteLine();
                        }
                    }

                } // 유저VS유저

                else if (num == 2) //컴 대결
                {
                    ischeck2 = true;
                    while (ischeck2 == true) //공격순서 무한 반복
                    {

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Computer VS  User");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("공격 순서 여부를 입력하세요. (선공은 '1', 후공은 '2') |  입력 : ");
                        string choice = Console.ReadLine();
                        int c = Convert.ToInt32(choice);

                        if (c == 1)
                        {
                            

                            ischeck3 = true;
                            while (ischeck3 == true) //컴과 유저의 반복
                            {
                                Console.Clear(); //초기화
                                board(); //바뀐판 보여주기
                                numChange0(); // '유저'가 입력한 번호 바꾸기
                                Console.Clear(); // 초기화
                                board(); //바뀐판 보여주기
                                escape(); // 성공 탈출 여부 확인
                                if (ischeck2 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 메인
                                else if (ischeck3 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 게임 반복

                                Console.Clear(); //초기화
                                board(); // 판보여주기
                                Console.WriteLine();
                                Console.WriteLine("Enter를 누르세요."); //창보여주고 엔터
                                Console.ReadLine();
                                realComCheck(); // 중복 > 방어 > X입력

                                escape(); //탈출확인
                                if (ischeck2 == false)
                                {
                                    computerVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 메인
                                else if (ischeck3 == false)
                                {
                                    computerVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 게임반복

                            }
                        }

                        else if (c == 2)
                        {
                            Console.Clear();
                            board(); // 판보여주기
                            Console.WriteLine();
                            Console.WriteLine("Enter를 누르세요.");
                            Console.ReadLine();

                            array[1, 1] = 'X';

                            ischeck3 = true;
                            while (ischeck3 == true) //컴과 유저의 반복
                            {
                                Console.Clear(); //초기화
                                board(); //바뀐판 보여주기
                                numChange0(); // '유저'가 입력한 번호 바꾸기
                                Console.Clear(); // 초기화
                                board(); //바뀐판 보여주기
                                escape(); // 성공 탈출 여부 확인
                                if (ischeck2 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 메인
                                else if (ischeck3 == false)
                                {
                                    oVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 게임 반복

                                Console.Clear(); //초기화
                                board(); // 판보여주기
                                Console.WriteLine();
                                Console.WriteLine("Enter를 누르세요.");//창보여주고 엔터
                                Console.ReadLine(); 
                                realComCheck(); // 중복 > 방어 > X입력

                                escape(); //탈출확인
                                if (ischeck2 == false)
                                {
                                    computerVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 메인
                                else if (ischeck3 == false)
                                {
                                    computerVictory++;
                                    Console.Clear();
                                    break;
                                } //점수기록 후 게임반복

                            }
                        }
                        else //무한반복
                        {
                            Console.WriteLine();
                            Console.WriteLine("다시 입력해주세요 !");
                            Console.WriteLine();
                        }

                    }

                } //컴VS유저

                else if (num == 3) //결과차트
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("            ScoreBoard            ");
                    Console.WriteLine("■■■■■■■■■■■■■■■■■");
                    Console.WriteLine();
                    Console.Write("        User 'O'  |  ");
                    Console.WriteLine(oVictory);
                    Console.Write("        User 'X'  |  ");
                    Console.WriteLine(xVictory);
                    Console.Write("    Computer 'X'  |  ");
                    Console.WriteLine(computerVictory);
                    Console.WriteLine();
                    Console.WriteLine("■■■■■■■■■■■■■■■■■");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("메인화면으로 돌아가려면 'Enter'를 눌러주세요.");
                    Console.ReadLine();

                } //점수판

                else if (num == 4)// fales되면서 시스템 종료
                {
                    ischeck = false;
                    break;
                } //종료
                
                else // 무한 반복
                {
                    Console.Clear();
                    Console.WriteLine("다시 입력해주세요 !");
                    Console.WriteLine();

                } //다시입력해주세요 무한반복

            }


            // 사용될 함수들?

            void main() //메인화면
            {
                Console.WriteLine("■■■■■■■■■■■■■■■■■");
                Console.WriteLine("■■■■■  Tic Tac Toe ■■■■■");
                Console.WriteLine("■■■■■■■■■■■■■■■■■");
                Console.WriteLine("■                              ■");
                Console.WriteLine("■    1. 'O' User VS 'X' User   ■");
                Console.WriteLine("■                              ■");
                Console.WriteLine("■    2. Computer VS  User      ■");
                Console.WriteLine("■                              ■");
                Console.WriteLine("■    3. ScoreBoard             ■");
                Console.WriteLine("■                              ■");
                Console.WriteLine("■    4. Exit                   ■");
                Console.WriteLine("■                              ■");
                Console.WriteLine("■■■■■■■■■■■■■■■■■");
                Console.WriteLine();
                Console.Write("번호를 입력해주세요 ! | 번호 : ");

            }

            void board()
            {

                Console.WriteLine("■■■■■■■■■■");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"■ {array[i, j]}  ");

                    }
                    Console.WriteLine("■");

                    if (i == i)
                    {
                        Console.WriteLine("■■■■■■■■■■");
                    }
                }


            } //삼목 판

            void numChange0()
            {
                Console.WriteLine();
                Console.WriteLine("'O'로 바꿀 번호를 입력하세요.");
                ischeck5 = true;
                while (ischeck5 == true)
                {
                    Console.WriteLine();
                    string number = Console.ReadLine();
                    char num = Convert.ToChar(number);
                    Console.WriteLine();

                    switch (num)
                    {
                        case '1':
                            if (array[0, 0] != 'X' && array[0, 0] != 'O')
                            {
                                array[0, 0] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '2':
                            if (array[0, 1] != 'X' && array[0, 1] != 'O')
                            {
                                array[0, 1] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '3':
                            if (array[0, 2] != 'X' && array[0, 2] != 'O')
                            {
                                array[0, 2] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;


                        case '4':
                            if (array[1, 0] != 'X' && array[1, 0] != 'O')
                            {
                                array[1, 0] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '5':
                            if (array[1, 1] != 'X' && array[1, 1] != 'O')
                            {
                                array[1, 1] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '6':
                            if (array[1, 2] != 'X' && array[1, 2] != 'O')
                            {
                                array[1, 2] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '7':
                            if (array[2, 0] != 'X' && array[2, 0] != 'O')
                            {
                                array[2, 0] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '8':
                            if (array[2, 1] != 'X' && array[2, 1] != 'O')
                            {
                                array[2, 1] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '9':
                            if (array[2, 2] != 'X' && array[2, 2] != 'O')
                            {
                                array[2, 2] = 'O';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        default:
                            Console.WriteLine("다시 입력해주세요 !");
                            break;

                    }
                }
            } //o로 바꾸기

            void numChange1()
            {
                Console.WriteLine();
                Console.WriteLine("'X'로 바꿀 번호를 입력하세요.");
                ischeck5 = true;
                while (ischeck5 == true)
                {
                    Console.WriteLine();
                    string number = Console.ReadLine();
                    char num = Convert.ToChar(number);
                    Console.WriteLine();

                    switch (num)
                    {
                        case '1':
                            if (array[0, 0] != 'O' && array[0, 0] != 'X')
                            {
                                array[0, 0] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '2':
                            if (array[0, 1] != 'O' && array[0, 1] != 'X')
                            {
                                array[0, 1] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '3':
                            if (array[0, 2] != 'O' && array[0, 2] != 'X')
                            {
                                array[0, 2] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;


                        case '4':
                            if (array[1, 0] != 'O' && array[1, 0] != 'X')
                            {
                                array[1, 0] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '5':
                            if (array[1, 1] != 'O' && array[1, 1] != 'X')
                            {
                                array[1, 1] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '6':
                            if (array[1, 2] != 'O' && array[1, 2] != 'X')
                            {
                                array[1, 2] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '7':
                            if (array[2, 0] != 'O' && array[2, 0] != 'X')
                            {
                                array[2, 0] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '8':
                            if (array[2, 1] != 'O' && array[2, 1] != 'X')
                            {
                                array[2, 1] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        case '9':
                            if (array[2, 2] != 'O' && array[2, 2] != 'X')
                            {
                                array[2, 2] = 'X';
                                ischeck5 = false;
                            }
                            else
                            {
                                Console.WriteLine("다시 입력해주세요!");
                            }
                            break;

                        default:
                            Console.WriteLine("다시 입력해주세요 !");
                            break;

                    }
                }
            } //x로 바꾸기

            void escape() // 성공탈출 여부확인 
            {

                if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] == array[0, 2])
                {
                    if (array[0, 0] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();

                    }
                    else if (array[0, 0] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] == array[1, 2])
                {
                    if (array[1, 0] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[1, 0] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] == array[2, 2])
                {
                    if (array[2, 0] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[2, 0] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] == array[2, 0])
                {
                    if (array[0, 0] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[0, 0] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] == array[2, 1])
                {
                    if (array[0, 1] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[0, 1] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] == array[2, 2])
                {
                    if (array[0, 2] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[0, 2] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] == array[2, 2])
                {
                    if (array[0, 0] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[0, 0] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                else if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[1, 1] == array[2, 0])
                {
                    if (array[0, 2] == 'O')
                    {
                        Console.Clear();
                        board();
                        oWin();
                    }
                    else if (array[0, 2] == 'X')
                    {
                        Console.Clear();
                        board();
                        xWin();
                    }
                }
                

            } // 삼목 완성

            void routineO() //유저 O 루틴
            {
                numChange0(); // '유저1'가 입력한 번호 바꾸기

                Console.Clear(); // 초기화

                board(); //바뀐판 보여주기

                escape(); // 성공 탈출 여부 확인

            } //o의 루틴

            void routineX() //유저 X 루틴
            {
                numChange1(); // '유저2'가 입력한 번호 바꾸기

                Console.Clear(); // 초기화

                board(); //바뀐판 보여주기

                escape(); // 성공 탈출 여부 확인
            } //x의 루틴

            void oWin()
            {
                ischeck4 = true;
                while (ischeck4 == true)
                {

                    Console.WriteLine();
                    Console.WriteLine("'O'이 이겼습니다!");
                    Console.WriteLine();
                    Console.WriteLine("메인화면으로 돌아가기는 'm', 다시하기 'b'를 입력해주세요.");
                    a = Console.ReadLine();



                    if (a == "m")
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        ischeck2 = false;
                        ischeck4 = false;


                    }
                    else if (a == "b")
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        ischeck3 = false;
                        ischeck4 = false;


                    }
                    else
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        Console.WriteLine("다시입력해주세요 !");
                    }
                }


            } //o가 이겼을때 탈출문구

            void xWin()
            {
                ischeck4 = true;
                while (ischeck4 == true)
                {

                    Console.WriteLine();
                    Console.WriteLine("'X'이 이겼습니다!");
                    Console.WriteLine();
                    Console.WriteLine("메인화면으로 돌아가기는 'm', 다시하기 'b'를 입력해주세요.");
                    a = Console.ReadLine();



                    if (a == "m")
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        ischeck2 = false;
                        ischeck4 = false;


                    }
                    else if (a == "b")
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        ischeck3 = false;
                        ischeck4 = false;


                    }
                    else
                    {
                        Array.Clear(array);
                        array[0, 0] = '1';
                        array[0, 1] = '2';
                        array[0, 2] = '3';
                        array[1, 0] = '4';
                        array[1, 1] = '5';
                        array[1, 2] = '6';
                        array[2, 0] = '7';
                        array[2, 1] = '8';
                        array[2, 2] = '9';
                        Console.WriteLine("다시입력해주세요 !");
                    }
                }

            } //x가 이겼을때 탈출문구

            void arrayClean() //배열 초기화 후 지정
            {

                char[,] array = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
                array[0, 0] = '1';
                array[0, 1] = '2';
                array[0, 2] = '3';
                array[1, 0] = '4';
                array[1, 1] = '5';
                array[1, 2] = '6';
                array[2, 0] = '7';
                array[2, 1] = '8';
                array[2, 2] = '9';
            } // 판 초기화

            void duplicateCheck()
            {
                
                //5
                if (array[1, 1] != 'O' && array[1, 1] != 'X')
                {
                    array[1, 1] = 'X';
                    ischeck6 = false;
                }
               
                //3
                else if (array[0, 2] != 'O' && array[0, 2] != 'X')
                {
                    array[0, 2] = 'X';
                    ischeck6 = false;
                }

                //1
                else if (array[0, 0] != 'O' && array[0, 0] != 'X') 
                {
                    array[0, 0] = 'X';
                    ischeck6 = false;
                }
                //9
                else if (array[2, 2] != 'O' && array[2, 2] != 'X')
                {
                    array[2, 2] = 'X';
                    ischeck6 = false;
                }
                //7
                else if (array[2, 0] != 'O' && array[2, 0] != 'X')
                {
                    array[2, 0] = 'X';
                    ischeck6 = false;
                }
                //2
                else if (array[0, 1] != 'O' && array[0, 1] != 'X')
                {
                    array[0, 1] = 'X';
                    ischeck6 = false;
                }
                
                //4
                else if (array[1, 0] != 'O' && array[1, 0] != 'X')
                {
                    array[1, 0] = 'X';
                    ischeck6 = false;
                }
                
                //6
                else if (array[1, 2] != 'O' && array[1, 2] != 'X')
                {
                    array[1, 2] = 'X';
                    ischeck6 = false;
                }
                
                //8
                else if (array[2, 1] != 'O' && array[2, 1] != 'X')
                {
                    array[2, 1] = 'X';
                    ischeck6 = false;
                }
               
                //
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("무승부입니다!");
                    Console.WriteLine();
                }

            } //중복체크 후 바로 X 놓기

            void newDuplicateCheck()
            {
                if (array[1, 1] != 'O' && array[1, 1] != 'X')
                {
                    array[1, 1] = 'X';
                }
                //1
                else if (array[0, 0] != 'O' && array[0, 0] != 'X')
                {
                    array[0, 0] = 'X';
                }
                //3
                else if (array[0, 2] != 'O' && array[0, 2] != 'X')
                {
                    array[0, 2] = 'X';
                }
                //7
                else if (array[2, 0] != 'O' && array[2, 0] != 'X')
                {
                    array[2, 0] = 'X';
                }
                //9
                else if (array[2, 2] != 'O' && array[2, 2] != 'X')
                {
                    array[2, 2] = 'X';
                }
                //2
                else if (array[0, 1] != 'O' && array[0, 1] != 'X')
                {
                    array[0, 1] = 'X';
                }
                //4
                else if (array[1, 0] != 'O' && array[1, 0] != 'X')
                {
                    array[1, 0] = 'X';
                }
                //6
                else if (array[1, 2] != 'O' && array[1, 2] != 'X')
                {
                    array[1, 2] = 'X';
                }
                //8
                else if (array[2, 1] != 'O' && array[2, 1] != 'X')
                {
                    array[2, 1] = 'X';
                }
            }

            void comCheck()
            {
                // 5부터 확인 들어감
                if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                {
                    array[1, 1] = 'X';

                }
                // 1
                else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                {
                    array[0, 0] = 'X';
                }
                //2
                else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                {
                    array[0, 1] = 'X';

                }
                //3
                else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                {
                    array[0, 2] = 'X';

                }
                //4
                else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                {
                    array[1, 0] = 'X';
                }
                //6
                else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                {
                    array[1, 2] = 'X';
                }
                //7
                else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                {
                    array[2, 0] = 'X';
                }
                //8
                else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                {
                    array[2, 1] = 'X';
                }
                //9
                else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                {
                    array[2, 2] = 'X';
                }
                //중복도 5부터 내맘대로 우선순위로 확인함
                else if (array[1, 1] != 'O' && array[1, 1] != 'X')
                {
                    array[1, 1] = 'X';
                }
                //1
                else if (array[0, 0] != 'O' && array[0, 0] != 'X')
                {
                    array[0, 0] = 'X';
                }
                //3
                else if (array[0, 2] != 'O' && array[0, 2] != 'X')
                {
                    array[0, 2] = 'X';
                }
                //7
                else if (array[2, 0] != 'O' && array[2, 0] != 'X')
                {
                    array[2, 0] = 'X';
                }
                //9
                else if (array[2, 2] != 'O' && array[2, 2] != 'X')
                {
                    array[2, 2] = 'X';
                }
                //2
                else if (array[0, 1] != 'O' && array[0, 1] != 'X')
                {
                    array[0, 1] = 'X';
                }
                //4
                else if (array[1, 0] != 'O' && array[1, 0] != 'X')
                {
                    array[1, 0] = 'X';
                }
                //6
                else if (array[1, 2] != 'O' && array[1, 2] != 'X')
                {
                    array[1, 2] = 'X';
                }
                //8
                else if (array[2, 1] != 'O' && array[2, 1] != 'X')
                {
                    array[2, 1] = 'X';
                }
            } // 방어 > 중복 > X놓기 (미완성)

            void comCheckR()
            {
                char doIt1 = '1';
                char doIt2 = '2';
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] != 'O' && array[i, j] != 'X')
                        {
                                doIt1 = (char)i; //빈칸찾기
                                doIt2 = (char)j;  //
                                
                        }
                    }

                }

                if (array[doIt1, doIt2] != 'O' && array[doIt1, doIt2] != 'X') //5부터 확인 시작
                {
                    //5부터
                    if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        array[1, 1] = 'X';

                    }
                    // 1
                    else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        array[0, 0] = 'X';
                    }
                    //2
                    else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        array[0, 1] = 'X';

                    }
                    //3
                    else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        array[0, 2] = 'X';

                    }
                    //4
                    else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        array[1, 0] = 'X';
                    }
                    //6
                    else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        array[1, 2] = 'X';
                    }
                    //7
                    else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        array[2, 0] = 'X';
                    }
                    //8
                    else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        array[2, 1] = 'X';
                    }
                    //9
                    else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        array[2, 2] = 'X';
                    }
                    // 나머지는 그냥 빈칸 순서대로 찍어!
                    else
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] == array[doIt1, doIt2])
                                {
                                    array[i, j] = 'X';
                                }
                            }
                        }


                    }
                }
                
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("무승부입니다!");
                    Console.WriteLine();
                }
            }

            void comCheckRR()
            {
                // 1. 판을 훑어서 빈칸을 찾는다. >>> 이게 개 에바임.. 도대체 뭐가 문제인지를 모르겠음.
                // 2. 빈칸을 채워 넣는 우선 순위를 만든다.
                // 3. 빈칸이 없을 경우 무승부 (이후 생각)
                
                char numO = '0';
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = numO;
                    }
                }
                

                if (numO != 'O' && numO != 'X')
                {
                    //5부터
                    if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        if (array[1, 1] != 'O' && array[1, 1] != 'X')
                        {
                            array[1, 1] = 'X';
                        }
                    }
                    // 1
                    else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        if (array[0, 0] != 'O' && array[0, 0] != 'X')
                        {
                            array[0, 0] = 'X';
                        }
                    }
                    //3
                    else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        if (array[0, 2] != 'O' && array[0, 2] != 'X')
                        {
                            array[0, 2] = 'X';
                        }
                    }
                    //7
                    else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        if (array[2, 0] != 'O' && array[2, 0] != 'X')
                        {
                            array[2, 0] = 'X';
                        }
                    }
                    //9
                    else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        if (array[2, 2] != 'O' && array[2, 2] != 'X')
                        {
                            array[2, 2] = 'X';
                        }
                    }
                    //2
                    else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        if (array[0, 1] != 'O' && array[0, 1] != 'X')
                        {
                            array[0, 1] = 'X';
                        }

                    }
                    //4
                    else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        if (array[1, 0] != 'O' && array[1, 0] != 'X')
                        {
                            array[1, 0] = 'X';
                        }
                    }
                    //6
                    else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        if (array[1, 2] != 'O' && array[1, 2] != 'X')
                        {
                            array[1, 2] = 'X';
                        }
                    }
                    //8
                    else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        if (array[2, 1] != 'O' && array[2, 1] != 'X')
                        {
                            array[2, 1] = 'X';
                        }
                    }
                    else
                    {
                        duplicateCheck();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("무승부입니다!");
                    Console.WriteLine();
                }

            }

            void repeatFirst()
            {
                //5부터
                if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                {
                    if (array[1, 1] != 'O' && array[1, 1] != 'X')
                    {
                        array[1, 1] = 'X';
                        ischeck6 = false;
                    }
                }
                //3
                else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                {
                    if (array[0, 2] != 'O' && array[0, 2] != 'X')
                    {
                        array[0, 2] = 'X';
                        ischeck6 = false;
                    }
                }
                //7
                else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                {
                    if (array[2, 0] != 'O' && array[2, 0] != 'X')
                    {
                        array[2, 0] = 'X';
                        ischeck6 = false;
                    }
                }
                //2
                else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                {
                    if (array[0, 1] != 'O' && array[0, 1] != 'X')
                    {
                        array[0, 1] = 'X';
                        ischeck6 = false;
                    }
                }
                //4
                else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                {
                    if (array[1, 0] != 'O' && array[1, 0] != 'X')
                    {
                        array[1, 0] = 'X';
                        ischeck6 = false;
                    }
                }
                //6
                else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                {
                    if (array[1, 2] != 'O' && array[1, 2] != 'X')
                    {
                        array[1, 2] = 'X';
                        ischeck6 = false;
                    }
                }
                //8
                else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                {
                    if (array[2, 1] != 'O' && array[2, 1] != 'X')
                    {
                        array[2, 1] = 'X';
                        ischeck6 = false;
                    }
                }
                //9
                else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                {
                    if (array[2, 2] != 'O' && array[2, 2] != 'X')
                    {
                        array[2, 2] = 'X';
                        ischeck6 = false;
                    }
                }
                // 1
                else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                {
                    if (array[0, 0] != 'O' && array[0, 0] != 'X')
                    {
                        array[0, 0] = 'X';
                        ischeck6 = false;
                    }
                }
            }

            void realComCheck()
            {
                ischeck6 = true;
                while (ischeck6 == true)
                {
                    //5부터
                    if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        if (array[1, 1] != 'O' && array[1, 1] != 'X')
                        {
                            array[1, 1] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //3
                    else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        if (array[0, 2] != 'O' && array[0, 2] != 'X')
                        {
                            array[0, 2] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //7
                    else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        if (array[2, 0] != 'O' && array[2, 0] != 'X')
                        {
                            array[2, 0] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //2
                    else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        if (array[0, 1] != 'O' && array[0, 1] != 'X')
                        {
                            array[0, 1] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //4
                    else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        if (array[1, 0] != 'O' && array[1, 0] != 'X')
                        {
                            array[1, 0] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //6
                    else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        if (array[1, 2] != 'O' && array[1, 2] != 'X')
                        {
                            array[1, 2] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //8
                    else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        if (array[2, 1] != 'O' && array[2, 1] != 'X')
                        {
                            array[2, 1] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //9
                    else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        if (array[2, 2] != 'O' && array[2, 2] != 'X')
                        {
                            array[2, 2] = 'X';
                            ischeck6 = false;
                        }
                    }
                    // 1
                    else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        if (array[0, 0] != 'O' && array[0, 0] != 'X')
                        {
                            array[0, 0] = 'X';
                            ischeck6 = false;
                        }
                    }
                    //다시 돌아
                    //5
                    if (array[1, 1] != 'O' && array[1, 1] != 'X')
                    {
                        array[1, 1] = 'X';
                        ischeck6 = false;
                    }

                    //3
                    else if (array[0, 2] != 'O' && array[0, 2] != 'X')
                    {
                        array[0, 2] = 'X';
                        ischeck6 = false;
                    }

                    //1
                    else if (array[0, 0] != 'O' && array[0, 0] != 'X')
                    {
                        array[0, 0] = 'X';
                        ischeck6 = false;
                    }
                    //9
                    else if (array[2, 2] != 'O' && array[2, 2] != 'X')
                    {
                        array[2, 2] = 'X';
                        ischeck6 = false;
                    }
                    //7
                    else if (array[2, 0] != 'O' && array[2, 0] != 'X')
                    {
                        array[2, 0] = 'X';
                        ischeck6 = false;
                    }
                    //2
                    else if (array[0, 1] != 'O' && array[0, 1] != 'X')
                    {
                        array[0, 1] = 'X';
                        ischeck6 = false;
                    }

                    //4
                    else if (array[1, 0] != 'O' && array[1, 0] != 'X')
                    {
                        array[1, 0] = 'X';
                        ischeck6 = false;
                    }

                    //6
                    else if (array[1, 2] != 'O' && array[1, 2] != 'X')
                    {
                        array[1, 2] = 'X';
                        ischeck6 = false;
                    }

                    //8
                    else if (array[2, 1] != 'O' && array[2, 1] != 'X')
                    {
                        array[2, 1] = 'X';
                        ischeck6 = false;
                    }

                    //
                    

                }
            }

                void one()
                {
                    if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        if (array[0, 0] != 'O' && array[0, 0] != 'X')
                        {
                            array[0, 0] = 'X';
                        }

                    }
                    else
                    {
                        if (array[0, 0] != 'O' && array[0, 0] != 'X')
                        {
                            array[0, 0] = 'X';
                        }
                    }
                }

                void two()
                {
                    if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        if (array[0, 1] != 'O' && array[0, 1] != 'X')
                        {
                            array[0, 1] = 'X';
                        }

                    }
                    else
                    {
                        if (array[0, 1] != 'O' && array[0, 1] != 'X')
                        {
                            array[0, 1] = 'X';
                        }
                    }
                }

                void thee()
                {
                    if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        if (array[0, 2] != 'O' && array[0, 2] != 'X')
                        {
                            array[0, 2] = 'X';
                        }

                    }
                    else
                    {
                        if (array[0, 2] != 'O' && array[0, 2] != 'X')
                        {
                            array[0, 2] = 'X';
                        }
                    }
                }

                void four()
                {
                    if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        if (array[1, 0] != 'O' && array[1, 0] != 'X')
                        {
                            array[1, 0] = 'X';
                        }

                    }
                    else
                    {
                        if (array[1, 0] != 'O' && array[1, 0] != 'X')
                        {
                            array[1, 0] = 'X';
                        }
                    }
                }

                void five()
                {
                    if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        if (array[1, 1] != 'O' && array[1, 1] != 'X')
                        {
                            array[1, 1] = 'X';
                        }

                    }
                    else
                    {
                        if (array[1, 1] != 'O' && array[1, 1] != 'X')
                        {
                            array[1, 1] = 'X';
                        }
                    }
                }

                void six()
                {
                    if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        if (array[1, 2] != 'O' && array[1, 2] != 'X')
                        {
                            array[1, 2] = 'X';
                        }

                    }
                    else
                    {
                        if (array[1, 2] != 'O' && array[1, 2] != 'X')
                        {
                            array[1, 2] = 'X';
                        }
                    }
                }

                void seven()
                {
                    if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        if (array[2, 0] != 'O' && array[2, 0] != 'X')
                        {
                            array[2, 0] = 'X';
                        }

                    }
                    else
                    {
                        if (array[2, 0] != 'O' && array[2, 0] != 'X')
                        {
                            array[2, 0] = 'X';
                        }
                    }
                }

                void eight()
                {
                    if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        if (array[2, 1] != 'O' && array[2, 1] != 'X')
                        {
                            array[2, 1] = 'X';
                        }

                    }
                    else
                    {
                        if (array[2, 1] != 'O' && array[2, 1] != 'X')
                        {
                            array[2, 1] = 'X';
                        }
                    }
                }

                void nine()
                {
                    if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        if (array[2, 2] != 'O' && array[2, 2] != 'X')
                        {
                            array[2, 2] = 'X';
                        }

                    }
                    else
                    {
                        if (array[2, 2] != 'O' && array[2, 2] != 'X')
                        {
                            array[2, 2] = 'X';
                        }
                    }
                }

                void defence()
                {
                    // array 1
                    if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        if (array[0, 0] != 'O' && array[0, 0] != 'X')
                        {
                            array[0, 0] = 'X';
                        }

                    }

                    // array 2
                    else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        array[0, 1] = 'X';
                    }

                    // array 3
                    else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        array[0, 2] = 'X';
                    }

                    // 4
                    else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        array[1, 0] = 'X';
                    }

                    //5
                    else if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        array[1, 1] = 'X';
                    }

                    //6
                    else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        array[1, 2] = 'X';
                    }

                    //7
                    else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        array[2, 0] = 'X';
                    }

                    //8
                    else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        array[2, 1] = 'X';
                    }

                    //9
                    else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        array[2, 2] = 'X';
                    }

                } //방어

                void newDefence() //방어 중복 빼고
                {
                    //5부터
                    if (array[0, 0] == array[2, 2] || array[0, 2] == array[2, 0] || array[1, 0] == array[1, 2] || array[0, 1] == array[2, 1])
                    {
                        array[1, 1] = 'X';

                    }
                    // 1
                    else if (array[0, 1] == array[0, 2] || array[1, 1] == array[2, 2] || array[1, 0] == array[2, 0])
                    {
                        array[0, 0] = 'X';
                    }
                    //2
                    else if (array[1, 1] == array[2, 1] || array[0, 0] == array[0, 2])
                    {
                        array[0, 1] = 'X';

                    }
                    //3
                    else if (array[0, 0] == array[0, 1] || array[1, 1] == array[2, 0] || array[1, 2] == array[2, 2])
                    {
                        array[0, 2] = 'X';

                    }
                    //4
                    else if (array[0, 0] == array[2, 0] || array[1, 1] == array[1, 2])
                    {
                        array[1, 0] = 'X';
                    }
                    //6
                    else if (array[0, 2] == array[2, 2] || array[1, 0] == array[1, 1])
                    {
                        array[1, 2] = 'X';
                    }
                    //7
                    else if (array[0, 2] == array[1, 1] || array[2, 1] == array[2, 2] || array[0, 0] == array[1, 0])
                    {
                        array[2, 0] = 'X';
                    }
                    //8
                    else if (array[2, 0] == array[2, 2] || array[0, 1] == array[1, 1])
                    {
                        array[2, 1] = 'X';
                    }
                    //9
                    else if (array[2, 0] == array[2, 1] || array[0, 2] == array[1, 2] || array[0, 0] == array[1, 1])
                    {
                        array[2, 2] = 'X';
                    }
                    // 다시 우선순위 5부터
                    else
                    {
                        int run = 0; // 한번만 체크하고 탈출 하게 만드는 것 

                        if (run == 0)
                        {
                            array[1, 1] = 'X';
                            run++;

                        }
                        // 1
                        else if (run == 0)
                        {
                            array[0, 0] = 'X';
                            run++;
                        }
                        //2
                        else if (run == 0)
                        {
                            array[0, 1] = 'X';
                            run++;
                        }
                        //3
                        else if (run == 0)
                        {
                            array[0, 2] = 'X';
                            run++;
                        }
                        //4
                        else if (run == 0)
                        {
                            array[1, 0] = 'X';
                            run++;
                        }
                        //6
                        else if (run == 0)
                        {
                            array[1, 2] = 'X';
                            run++;
                        }
                        //7
                        else if (run == 0)
                        {
                            array[2, 0] = 'X';
                            run++;
                        }
                        //8
                        else if (run == 0)
                        {
                            array[2, 1] = 'X';
                            run++;
                        }
                        //9
                        else if (run == 0)
                        {
                            array[2, 2] = 'X';
                            run++;
                        }
                    }
                }



                /*
                if ( number == array[i, j])
                {
                    Console.Write("O");
                }
                */


            
        }
    }
}
