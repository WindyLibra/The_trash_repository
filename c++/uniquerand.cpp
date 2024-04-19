#include <iostream>
#include <random>
using std::cout, std::cin, std::string, std::endl;

int main()
{
    srand(time(0));

	int nums[20];
	bool alreadyThere;

	for (int i = 0; i < 20;)
	{
		alreadyThere = false;
		int smthnew = rand() % 20 + 1;

		for (int j = 0; j < i; j++)
		{
			if (nums[j] == smthnew) {
				alreadyThere = true;
			}
		}

		if (!alreadyThere) {
			nums[i] = smthnew;
			i++;
		}

	}

	for (int j : nums)
	{
		cout << j << "\n";
	}

	int minim = nums[0];
	for (int j: nums)
	{
		if (j < minim) {
			minim = j;
		}
	}

	cout << endl << minim << "\n";

    return 0;
}
