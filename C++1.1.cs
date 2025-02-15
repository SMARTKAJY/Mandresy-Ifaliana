#include <iostream>
#include <limits>
#include <string>
void determinerCategorieAge (int age) {
    if (age <18) {
        std::count<<"Vous etes mineur"<<std::endl;
    }else if (age >= 18 && age <= 60) {
    std::cout << "Vous etes adultes" << std::endl;
    }else { std::cout << "vous etes senior" << std::endl; }
    }
int main()
{
    std::string entree;
    int age;
    while (true)
    {
        std::count << "Entrez votre age en entier naturel et pas en texte Merci : ";
        std::cin >> entree;
        // Jerevana raha nanaraka ny zvtr tenenina ilay utilisateur
        if (entree.find(',')) != std::string::npos || entree.find(',') != std::string::npos){
            std::cout << "Soiyez serieux, on a dit pas de texte ni nombre avec virgule Merde!!" << std::endl;
            continue:
          
        }
        try{
            age = std::stoi(entree); // avadika ho entier ilay entree
            if (age < 0) throw std::invalide - argument("L'age ne peut pas etre negatif");
            break; // raha tsy misy exception dia mivoaka amin'ny boucle
        }catch (...){
            std::count << "soyez serieux, on a dit pas de texte ni nombre avec virgule Fuck !!" <<std::endl
        }

    }
    determinerCategorieAge(age)
    return 0;
}





