using DevExpress.Mvvm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public class SaveAsService : ISaveAsService
    {
        public void SaveAsCSVFile(ObservableCollection<Products> products)
        {
            bool status = false;
            if (products.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save As File";
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    if (saveFileDialog.FileName != null)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            const string header = "ProductId,Barcode,Name,item.Description,Price,Source";
                            writer.WriteLine(header);
                            foreach (var item in products)
                            {
                                writer.WriteLine($"{item.ProductId},{item.Barcode},{item.Name},{item.Description},{item.Price},{item.Source}");

                            }
                            writer.Close();
                            status = true;
                        }
                    }
                }
            }
            if (status)
                MessageBox.Show("File Saved!", "Saved Information", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("File has not Saved!", "Error Information", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void SaveAsTXTFile(ObservableCollection<Products> products)
        {
            //Anyway it can be used.
            bool status = false;
            if (products.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt| All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    if (saveFileDialog.FileName != null)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            const string header = "ProductId,Barcode,Name,item.Description,Price,Source";
                            writer.WriteLine(header);
                            foreach (var item in products)
                            {
                                writer.WriteLine($"{item.ProductId},{item.Barcode},{item.Name},{item.Description},{item.Price},{item.Source}");

                            }
                            writer.Close();
                            status = true;
                        }
                    }
                }
            }
            if (status)
                MessageBox.Show("Text File Saved!", "Saved Information", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("File has not Saved!", "Error Information", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
