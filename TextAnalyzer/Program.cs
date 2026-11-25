string choice;

do {
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
    choice = Console.ReadLine();

    switch (choice) {
        case "1": {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            int vowelCount = 0;
            int consonantCount = 0;
            int spaceCount = 0;

            foreach (char letter in sentence) {
                if (letter == ' ') {
                    spaceCount++;
                    continue;
                }
                if (vowels.Contains(letter)) {
                    vowelCount++;
                } else if (char.IsLetter(letter)) {
                    consonantCount++;
                }
            }

            Console.WriteLine($"Всего символов: {sentence.Length}");
            Console.WriteLine($"Гласных: {vowelCount}");
            Console.WriteLine($"Согласных: {consonantCount}");
            Console.WriteLine($"Пробелов: {spaceCount}");
            Console.WriteLine();
            break;
        }
        case "2": {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < sentence.Length; i++) {
                if (char.IsUpper(sentence[i])) {
                    Console.WriteLine($"Первая заглавная буква на позиции {i}: {sentence[i]}");
                    found = true;
                    break;
                }
            }

            if (!found) {
                Console.WriteLine("Заглавных букв нет");
            }
            Console.WriteLine();
            break;
        }
        case "0":
            Console.WriteLine("До свидания!");
            break;
        default:
            Console.WriteLine("Такого пункта нет, попробуйте снова.");
            Console.WriteLine();
            break;
    }
} while (choice != "0");