not1 = float(input("1.Dersin notunu girin: "))
not2 = float(input("2.Dersin notunu girin: "))
not3 = float(input("3.Dersin notunu girin: "))

# Ortalama hesaplama
ortalama = (ders1 + ders2 + ders3) / 3

# Sonucu kontrol etme
if ortalama > 50:
    print(f"Ortalamanız {ortalama:.2f}. Sınıfı geçtiniz")
else:
    print(f"Ortalamanız {ortalama:.2f}. Sınıfta kaldınız.")
