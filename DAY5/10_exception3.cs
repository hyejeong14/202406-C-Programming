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
        try
        {
            db.Backup();
        }
        catch (DBBackupFailException e)
        {
            WriteLine("DBBackup 실패");
            //예외의 원인을 해결할 수 없다면 여기서 프로그램 종료
            //여기서 종료하지 않으면 계속 실행가능
        }
        catch(Exception e) //위에서 잡지 못한 모든 예외를 잡을 때 사용
        {
            WriteLine("알 수 없는 예외")
        }
       

        db.Remove();
    }
}
