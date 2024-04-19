#include <iostream>
#include <random>
using namespace std;

int main()
{
  	srand(time(0));

	int RiskOfRain;
	cout << "What's the risk of rain? (0-100): ";
	cin >> RiskOfRain;

	cout << "ok, now we'll calculate whether it's raining or not..." << endl;
	bool rain = ((rand() % 101) < RiskOfRain);

	if (rain) {
		cout << "It's raining" << endl;
	} else {
		cout << "It's not raining" << endl;
	}

	return 0;
}
