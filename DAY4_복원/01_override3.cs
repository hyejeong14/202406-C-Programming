using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}

class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Cat : Animal
{
    public new void Cry() { WriteLine("3. Cat Cry"); }
}


class Program
{
    public static void Main()
    {
        // 73page.
        // �ٽ� #1. ����� �Է¿� ���� �ٸ� ��ü�� �������
        //          ������ Animal Ÿ������ �ؾ� �մϴ�.
        Animal a;

        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n == 1)
            a = new Dog();
        else
            a = new Cat();

        // �ٽ� #2. �����Ϸ��� �Ʒ� �ڵ带 ������ �Ҷ�
        // 1. a�� ����Ű�� ���� � ����(Dog, Cat) �� ��ü�� �ִ��� �˼� �����ϴ�.
        //    => ����ð� �Է� ���� ���� �����ǹǷ�
        // 2. �����Ϸ��� �ƴ� ���� "a��� ���� ��ü�� Animal Ÿ��" �̶�� ��!!
        a.Cry();
    }
}

// "a.Cry()" �� � �Լ��� �����Ұ��ΰ� ?
// => �Լ� ���ε�(function binding) �̶�� �մϴ�.

// �ٽ� 2 
//�����Ϸ��� �Ʒ� �ڵ带 ������ �� �� a�� ����Ű�� ���� � ���� (Dog or Cat)�� ��ü�� �ִ��� �� �� ����
//����ð� �Է� ���� ���� �����ǹǷ�!
//�����Ϸ��� �ƴ� ���� 
a.Cry();
       

        // �ٽ� 3. �Լ� ���ε��� ����
        // 1.static binding : �����Ϸ��� ������ �ð��� �Լ� ȣ���� ����
        //                    �����Ϸ��� a�� ����Ű�� ��ü�� ������ �� �� ����
        //                    ����, "a"�� Animal �̶�� �͸� �� �� ����.
        //                    ����, �����Ϸ��� �����ϸ� Animal Cry ȣ��
        //                    ����������� ����, cpp�� �⺻ ���ε� ��å

        // 2. dynamic binding : ������ �ÿ��� a�� ����Ű�� ���� �����ϴ� ���� ����
        //                      ����� �޸𸮸� �����ؼ� ���� �ִ� ��ü�� ���� ȣ�� ����
        //                      a�� ����Ű�� ���� Dog ��ü�� �ִٸ� Dog Cry ȣ��
        //                      static binding���� ���������� ������ ���� ���ϰ� �߻��� �� ����.
        //                      Java, Python�� �⺻ ���ε� ��å

    }
}
