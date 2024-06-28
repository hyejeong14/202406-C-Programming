using static System.Console;

int cnt = 0;
while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine();

cnt = 0;
while( true )
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
}

//while( cnt ) {} // error
