using System;
namespace fpgiuh
{
	interface IBaseArray: IPrinter
	{
		void Create(bool choice);

		decimal Average_Value();
	}
}

