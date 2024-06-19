using System;
using System.Collections.Generic;

// Node untuk menyimpan data tiket
public class Node
{
    public int IdTiket; // ID Tiket
    public string NamaPelanggan; // Nama Pelanggan
    public Node Berikutnya; // Referensi ke node berikutnya

    // Konstruktor untuk membuat node baru
    public Node(int id, string nama)
    {
        IdTiket = id;
        NamaPelanggan = nama;
        Berikutnya = null;
    }
}

// Linked List untuk menyimpan data tiket
public class LinkedList
{
    private Node kepala; // Node pertama dalam linked list

    // Method untuk menambahkan tiket ke linked list
    public void TambahTiket(int id, string nama) //Tambah Tiket: O(n)
    {
        Node simpulBaru = new Node(id, nama);
        if (kepala == null) // Jika linked list kosong
        {
            kepala = simpulBaru; // Jadikan simpul baru sebagai kepala
        }
        else
        {
            Node sementara = kepala;
            while (sementara.Berikutnya != null)
            {
                sementara = sementara.Berikutnya; // Cari simpul terakhir
            }
            sementara.Berikutnya = simpulBaru; // Tambah simpul baru di akhir
        }
    }

    // Method untuk menampilkan semua tiket dalam linked list
    public void TampilkanTiket() //O(n)
    {
        Node sementara = kepala;
        while (sementara != null)
        {
            Console.WriteLine($"ID Tiket: {sementara.IdTiket}, Pelanggan: {sementara.NamaPelanggan}");
            sementara = sementara.Berikutnya; // Pindah ke simpul berikutnya
        }
    }
}

// Queue untuk antrian tiket
public class AntrianTiket
{
    private Queue<Node> antrian = new Queue<Node>(); // Queue untuk menyimpan tiket

    // Method untuk menambahkan tiket ke antrian
    public void EnqueueTiket(int id, string nama) //O(1)
    {
        Node simpulBaru = new Node(id, nama);
        antrian.Enqueue(simpulBaru); // Tambahkan tiket ke antrian
    }

    // Method untuk mengeluarkan tiket dari antrian
    public void DequeueTiket() //O(1)
    {
        if (antrian.Count > 0)
        {
            Node tiketDihapus = antrian.Dequeue(); // Keluarkan tiket pertama
            Console.WriteLine($"Dihapus dari antrian: ID Tiket: {tiketDihapus.IdTiket}, Pelanggan: {tiketDihapus.NamaPelanggan}");
        }
        else
        {
            Console.WriteLine("Antrian kosong.");
        }
    }

    // Method untuk menampilkan semua tiket dalam antrian
    public void TampilkanAntrian() //O(n)
    {
        foreach (var tiket in antrian)
        {
            Console.WriteLine($"ID Tiket: {tiket.IdTiket}, Pelanggan: {tiket.NamaPelanggan}");
        }
    }
}

// Stack untuk menumpuk tiket
public class TumpukanTiket
{
    private Stack<Node> tumpukan = new Stack<Node>(); // Stack untuk menyimpan tiket

    // Method untuk menambahkan tiket ke tumpukan
    public void PushTiket(int id, string nama) //O(1)
    {
        Node simpulBaru = new Node(id, nama);
        tumpukan.Push(simpulBaru); // Tambahkan tiket ke tumpukan
    }

    // Method untuk mengeluarkan tiket dari tumpukan
    public void PopTiket() //O(1)
    {
        if (tumpukan.Count > 0)
        {
            Node tiketDihapus = tumpukan.Pop(); // Keluarkan tiket paling atas
            Console.WriteLine($"Dihapus dari tumpukan: ID Tiket: {tiketDihapus.IdTiket}, Pelanggan: {tiketDihapus.NamaPelanggan}");
        }
        else
        {
            Console.WriteLine("Tumpukan kosong.");
        }
    }

    // Method untuk menampilkan semua tiket dalam tumpukan
    public void TampilkanTumpukan() //O(n)
    {
        foreach (var tiket in tumpukan)
        {
            Console.WriteLine($"ID Tiket: {tiket.IdTiket}, Pelanggan: {tiket.NamaPelanggan}");
        }
    }
}

// Binary Search Tree (BST) untuk menyimpan tiket
public class BSTNode
{
    public int IdTiket;
    public string NamaPelanggan;
    public BSTNode Kiri; // Sub-pohon kiri
    public BSTNode Kanan; // Sub-pohon kanan

    public BSTNode(int id, string nama)
    {
        IdTiket = id;
        NamaPelanggan = nama;
        Kiri = null;
        Kanan = null;
    }
}

// Binary Search Tree (BST) untuk menyimpan tiket
public class BinarySearchTree
{
    private BSTNode akar; // Akar dari pohon BST

    // Method untuk menambahkan tiket ke BST
    public void Tambah(int id, string nama) //O(log n)
    {
        akar = TambahRekursif(akar, id, nama);
    }

    private BSTNode TambahRekursif(BSTNode akar, int id, string nama)
    {
        if (akar == null)
        {
            akar = new BSTNode(id, nama);
            return akar;
        }

        if (id < akar.IdTiket)
        {
            akar.Kiri = TambahRekursif(akar.Kiri, id, nama);
        }
        else if (id > akar.IdTiket)
        {
            akar.Kanan = TambahRekursif(akar.Kanan, id, nama);
        }

        return akar;
    }

    // Method untuk menampilkan semua tiket dalam BST secara in-order
    public void InOrder() //O(n)
    {
        InOrderRekursif(akar);
    }

    private void InOrderRekursif(BSTNode akar)
    {
        if (akar != null)
        {
            InOrderRekursif(akar.Kiri);
            Console.WriteLine($"ID Tiket: {akar.IdTiket}, Pelanggan: {akar.NamaPelanggan}");
            InOrderRekursif(akar.Kanan);
        }
    }
}

// Hash Table untuk menyimpan tiket
public class HashTableTiket
{
    private Dictionary<int, string> tabelHash = new Dictionary<int, string>(); // Dictionary untuk menyimpan tiket

    // Method untuk menambahkan tiket ke hash table
    public void TambahTiket(int id, string nama) //O(1)
    {
        if (!tabelHash.ContainsKey(id))
        {
            tabelHash.Add(id, nama); // Tambahkan tiket ke hash table
        }
        else
        {
            Console.WriteLine("ID Tiket sudah ada dalam tabel hash.");
        }
    }

    // Method untuk menghapus tiket dari hash table
    public void HapusTiket(int id) //O(1)
    {
        if (tabelHash.ContainsKey(id))
        {
            tabelHash.Remove(id); // Hapus tiket dari hash table
            Console.WriteLine($"ID Tiket: {id} berhasil dihapus dari tabel hash.");
        }
        else
        {
            Console.WriteLine("ID Tiket tidak ditemukan dalam tabel hash.");
        }
    }

    // Method untuk mencari tiket dalam hash table
    public bool CariTiket(int id) //O(1)
    {
        return tabelHash.ContainsKey(id); // Cari tiket dalam hash table
    }

    // Method untuk menampilkan semua tiket dalam hash table
    public void TampilkanTiket() //O(n)
    {
        foreach (var tiket in tabelHash)
        {
            Console.WriteLine($"ID Tiket: {tiket.Key}, Pelanggan: {tiket.Value}");
        }
    }
}

// Min Heap untuk menyimpan tiket
public class MinHeapTiket
{
    private List<Node> heap = new List<Node>(); // List untuk menyimpan tiket dalam bentuk heap

    // Method untuk menambahkan tiket ke heap
    public void TambahTiket(int id, string nama) //O(log n)
    {
        Node simpulBaru = new Node(id, nama);
        heap.Add(simpulBaru); // Tambahkan simpul baru ke akhir list
        HeapifyUp(heap.Count - 1); // Perbaiki heap ke atas mulai dari simpul baru

    }

    // Method untuk menghapus tiket dari heap
    public void HapusTiket() //O(log n)
    {
        if (heap.Count > 0)
        {
            Node tiketDihapus = heap[0]; // Simpan tiket yang akan dihapus
            heap[0] = heap[heap.Count - 1]; // Pindahkan elemen terakhir ke puncak
            heap.RemoveAt(heap.Count - 1); // Hapus elemen terakhir dari list
            HeapifyDown(0); // Perbaiki heap ke bawah mulai dari puncak
            Console.WriteLine($"Dihapus dari heap: ID Tiket: {tiketDihapus.IdTiket}, Pelanggan: {tiketDihapus.NamaPelanggan}");

        }
        else
        {
            Console.WriteLine("Heap kosong.");
        }
    }

    public void PerbaruiNamaPelanggan(int id, string namaBaru)
    {
        for (int i = 0; i < heap.Count; i++)
        {
            if (heap[i].IdTiket == id)
            {
                heap[i].NamaPelanggan = namaBaru;
                HeapifyUp(i); // Perbaiki heap ke atas
                HeapifyDown(i); // Perbaiki heap ke bawah
                Console.WriteLine($"Nama pelanggan untuk ID Tiket: {id} berhasil diperbarui menjadi {namaBaru}.");
                return;
            }
        }
        Console.WriteLine("ID Tiket tidak ditemukan dalam heap.");
    }
    // Kompleksitas:
    // - Pencarian dalam heap: O(n)
    // - HeapifyUp: O(log n)
    // - HeapifyDown: O(log n)
    // - Total kompleksitas: O(n + log n + log n) ≈ O(n)


    public Node CariTiket(int id)
    {
        foreach (var tiket in heap)
        {
            if (tiket.IdTiket == id)
            {
                return tiket;
            }
        }
        return null;
    }
    // Kompleksitas:
    // - Pencarian dalam heap menggunakan perulangan foreach: O(n)



    // Method untuk menampilkan semua tiket dalam heap
    public void TampilkanHeap() //O(n)
    {
        foreach (var tiket in heap)
        {
            Console.WriteLine($"ID Tiket: {tiket.IdTiket}, Pelanggan: {tiket.NamaPelanggan}");
        }
    }

    private void HeapifyUp(int index) //O(log n)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2; // Hitung indeks parent
            if (heap[index].IdTiket < heap[parentIndex].IdTiket)
            {
                Swap(index, parentIndex);// Tukar jika child lebih kecil dari parent
                index = parentIndex; // Perbarui indeks ke parent
            }
            else
            {
                break;
            }
        }
    }

    private void HeapifyDown(int index) //O(log n)
    {
        int lastIndex = heap.Count - 1;
        while (index < lastIndex)
        {
            int leftChildIndex = 2 * index + 1; // Hitung indeks child kiri
            int rightChildIndex = 2 * index + 2; // Hitung indeks child kanan
            int smallestChildIndex = index;

            if (leftChildIndex <= lastIndex && heap[leftChildIndex].IdTiket < heap[smallestChildIndex].IdTiket)
            {
                smallestChildIndex = leftChildIndex;// Pilih child kiri jika lebih kecil
            }
            if (rightChildIndex <= lastIndex && heap[rightChildIndex].IdTiket < heap[smallestChildIndex].IdTiket)
            {
                smallestChildIndex = rightChildIndex;// Pilih child kanan jika lebih kecil
            }
            if (smallestChildIndex != index)
            {
                Swap(index, smallestChildIndex);// Tukar jika child lebih kecil dari parent
                index = smallestChildIndex;// Perbarui indeks ke child terkecil
            }
            else
            {
                break;// Hentikan jika heap property sudah benar
            }
        }
    }

    private void Swap(int index1, int index2)
    {
        Node temp = heap[index1];
        heap[index1] = heap[index2];
        heap[index2] = temp;
    }
}
// Kompleksitas:
// - Penukaran dua elemen dalam heap: O(1)

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        AntrianTiket antrian = new AntrianTiket();
        TumpukanTiket tumpukan = new TumpukanTiket();
        BinarySearchTree bst = new BinarySearchTree();
        HashTableTiket hashTable = new HashTableTiket();
        MinHeapTiket minHeap = new MinHeapTiket();

        while (true)
        {
            Console.WriteLine("QTIX");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tambah Tiket ke Linked List");
            Console.WriteLine("2. Tampilkan Tiket Linked List");
            Console.WriteLine("3. Masukkan Tiket ke Antrian");
            Console.WriteLine("4. Keluarkan Tiket dari Antrian");
            Console.WriteLine("5. Tampilkan Tiket Antrian");
            Console.WriteLine("6. Masukkan Tiket ke Tumpukan");
            Console.WriteLine("7. Keluarkan Tiket dari Tumpukan");
            Console.WriteLine("8. Tampilkan Tiket Tumpukan");
            Console.WriteLine("9. Tambah Tiket ke BST");
            Console.WriteLine("10. Tampilkan BST In-Order");
            Console.WriteLine("11. Tambah Tiket ke Hash Table");
            Console.WriteLine("12. Hapus Tiket dari Hash Table");
            Console.WriteLine("13. Cari Tiket di Hash Table");
            Console.WriteLine("14. Tampilkan Tiket Hash Table");
            Console.WriteLine("15. Tambah Tiket ke Heap");
            Console.WriteLine("16. Hapus Tiket dari Heap");
            Console.WriteLine("17. Perbarui Nama Pelanggan di Heap");
            Console.WriteLine("18. Cari Tiket di Heap");
            Console.WriteLine("19. Tampilkan Tiket Heap");
            Console.WriteLine("20. Keluar");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Pilih menu: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan ID Tiket: ");
                    int idLinkedList = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaLinkedList = Console.ReadLine();
                    linkedList.TambahTiket(idLinkedList, namaLinkedList);
                    break;
                case 2:
                    linkedList.TampilkanTiket();
                    break;
                case 3:
                    Console.Write("Masukkan ID Tiket: ");
                    int idAntrian = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaAntrian = Console.ReadLine();
                    antrian.EnqueueTiket(idAntrian, namaAntrian);
                    break;
                case 4:
                    antrian.DequeueTiket();
                    break;
                case 5:
                    antrian.TampilkanAntrian();
                    break;
                case 6:
                    Console.Write("Masukkan ID Tiket: ");
                    int idTumpukan = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaTumpukan = Console.ReadLine();
                    tumpukan.PushTiket(idTumpukan, namaTumpukan);
                    break;
                case 7:
                    tumpukan.PopTiket();
                    break;
                case 8:
                    tumpukan.TampilkanTumpukan();
                    break;
                case 9:
                    Console.Write("Masukkan ID Tiket: ");
                    int idBST = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaBST = Console.ReadLine();
                    bst.Tambah(idBST, namaBST);
                    break;
                case 10:
                    bst.InOrder();
                    break;
                case 11:
                    Console.Write("Masukkan ID Tiket: ");
                    int idHashTable = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaHashTable = Console.ReadLine();
                    hashTable.TambahTiket(idHashTable, namaHashTable);
                    break;
                case 12:
                    Console.Write("Masukkan ID Tiket yang ingin dihapus: ");
                    int idHapusHashTable = Convert.ToInt32(Console.ReadLine());
                    hashTable.HapusTiket(idHapusHashTable);
                    break;
                case 13:
                    Console.Write("Masukkan ID Tiket yang ingin dicari: ");
                    int idCariHashTable = Convert.ToInt32(Console.ReadLine());
                    bool ditemukan = hashTable.CariTiket(idCariHashTable);
                    Console.WriteLine(ditemukan ? "Tiket ditemukan." : "Tiket tidak ditemukan.");
                    break;
                case 14:
                    hashTable.TampilkanTiket();
                    break;
                case 15:
                    Console.Write("Masukkan ID Tiket: ");
                    int idHeap = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan: ");
                    string namaHeap = Console.ReadLine();
                    minHeap.TambahTiket(idHeap, namaHeap);
                    break;
                case 16:
                    minHeap.HapusTiket();
                    break;
                case 17:
                    Console.Write("Masukkan ID Tiket yang ingin diperbarui: ");
                    int idPerbaruiHeap = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Nama Pelanggan Baru: ");
                    string namaBaruHeap = Console.ReadLine();
                    minHeap.PerbaruiNamaPelanggan(idPerbaruiHeap, namaBaruHeap);
                    break;
                case 18:
                    Console.Write("Masukkan ID Tiket yang ingin dicari: ");
                    int idCariHeap = Convert.ToInt32(Console.ReadLine());
                    Node tiketDitemukan = minHeap.CariTiket(idCariHeap);
                    if (tiketDitemukan != null)
                    {
                        Console.WriteLine($"Tiket ditemukan: ID Tiket: {tiketDitemukan.IdTiket}, Pelanggan: {tiketDitemukan.NamaPelanggan}");
                    }
                    else
                    {
                        Console.WriteLine("Tiket tidak ditemukan.");
                    }
                    break;
                case 19:
                    minHeap.TampilkanHeap();
                    break;
                case 20:
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
