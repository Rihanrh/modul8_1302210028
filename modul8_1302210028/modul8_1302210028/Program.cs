// See https://aka.ms/new-console-template for more information

using modul8_1302210028;

public class program
{
    public static void Main(string[] args)
    {
        AppConfig app = new AppConfig();

        if (app.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < app.config.transfer.threshold)
            {
                Console.WriteLine("Transfer fee = " + money);
                Console.WriteLine("Total amount = " + (money + app.config.transfer.low_fee));
            }
            else
            {
                Console.WriteLine("Transfer fee = " + money);
                Console.WriteLine("Total amount = " + (money + app.config.transfer.high_fee));
            }

            Console.WriteLine("\nSelect transfer method:");
            for (int i = 0; i < app.config.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + ". "+ app.config.methods[i]);
            }
            Console.Write("Input: ");
            int method = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease type \"" + app.config.confirmation.en + "\" to confirm the transaction");
            string confirm = Console.ReadLine();

            if (confirm == app.config.confirmation.en)
            {
                Console.WriteLine("The transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }
        else if (app.config.lang == "id")
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < app.config.transfer.threshold)
            {
                Console.WriteLine("Biaya transfer = " + money);
                Console.WriteLine("Total biaya = " + (money + app.config.transfer.low_fee));
            }
            else
            {
                Console.WriteLine("Biaya transfer = " + money);
                Console.WriteLine("Total biaya = " + (money + app.config.transfer.high_fee));
            }

            Console.WriteLine("\nPilih metode transfer:");
            for (int i = 0; i < app.config.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + app.config.methods[i]);
            }
            Console.Write("Input: ");
            int method = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nKetik \"" + app.config.confirmation.id + "\" untuk mengkonfirmasi transaksi");
            string confirm = Console.ReadLine();

            if (confirm == app.config.confirmation.id)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }
    }
}