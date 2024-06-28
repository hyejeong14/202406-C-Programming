using static System.Console;

// 객체지향 언어의 오류 처리 방법
// #1. 메소드가 실패하면 예외를 던져주기

//실패의 다양한 원인을 담은 클래스를 설계
//예외 클래스 규칙
//Exception에서 파생되어야 함

class DBBackupFailException
{
    //이 안에 실패의 이유를 정확히 전달하기 위한 다양한 멤버 추가
   
}

class DB
{

    public void Backup()
    {
        if (true) //실패라고 가정
        { 
            throw new DBBackupFailException();
        }
       
    }

    public void Remove() { WriteLine("Remove DB"); }
}
class Program
{
    public static void Main()
    {
        DB db = new DB();

        db.Backup(); //예외를 던졌을 때 안 잡으면 뻑남

        db.Remove();
    }
}
