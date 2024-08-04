#include <stdio.h>
#include <ctype.h>

int main() {


    double temp;
    char typefrom;
    char typeto;

    printf("What system do you use?(C/K/F): ");
    scanf("%c", &typefrom);
    printf("How many degrees?: ");
    scanf("%lf", &temp);
    while (getchar() != '\n');
    printf("What we are converting to?(C/K/F): ");
    scanf("%c", &typeto);

    typefrom = toupper(typefrom);
    typeto = toupper(typeto);

    if (typeto == typefrom){
        printf("Why in the fuck you're converting to the same base?\nSorry next time bro");
        return 0;
    }

    switch(typefrom){
        case 'C':
            if (typeto == 'K') {
                temp = temp + 273;
            } else if (typeto == 'F') {
                temp = (temp * 9 / 5) + 32;
            }
            break;
        case 'F':
            if (typeto == 'C') {
                temp = (temp - 32) * 5 / 9;
            } else if (typeto == 'K') {
                temp = (temp - 32) * 5 / 9 + 273;
            }
            break;
        case 'K':
            if (typeto == 'C') {
                temp = temp - 273;
            } else if (typeto == 'F') {
                temp = ((temp - 273) * 9 / 5) + 32;
            }
            break;
        default:
            printf("You entered wrong temperature type");
            return 0;
    }

    printf("The temperature is %lf", temp);

    return 0;
}
