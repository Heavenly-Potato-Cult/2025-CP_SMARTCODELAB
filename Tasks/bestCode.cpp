#include <iostream>
#include <string>
using namespace std;

int romanToInt(string s) {
    int total = 0;
    int n = s.length();
    
    for (int i = 0; i < n; i++) {
        switch(s[i]) {
            case 'I': {
                if (i + 1 < n && (s[i + 1] == 'V' || s[i + 1] == 'X')) {
                    total -= 1;
                }
                else {
                    total += 1;
                }
                break;
            }
            case 'V': {
                total += 5;
                break;
            }
            case 'X': {
                if (i + 1 < n && (s[i + 1] == 'L' || s[i + 1] == 'C')) {
                    total -= 10;
                }
                else {
                    total += 10;
                }
                break;
            }
            case 'L': {
                total += 50;
                break;
            }
            case 'C': {
                if (i + 1 < n && (s[i + 1] == 'D' || s[i + 1] == 'M')) {
                    total -= 100;
                }
                else {
                    total += 100;
                }
                break;
            }
            case 'D': {
                total += 500;
                break;
            }
            case 'M': {
                total += 1000;
                break;
            }
        }
    }
    return total;
}

int main() {
    string roman;
    cin >> roman;
    cout << romanToInt(roman) << endl;
}