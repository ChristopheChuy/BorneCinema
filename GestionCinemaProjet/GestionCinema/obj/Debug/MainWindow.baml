   M S B A M L   `   `   `  ����H  DGestionCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestionCinemaGestionCinema  5   	   K GGestionCinemaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLibGestionCinemaLib 5   	   M8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLibGestionCinemaLib 5   	       GestionCinema.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -localclr-namespace:GestionCinema     5   	   LCineLib8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLib     5   	   Gmy8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLib     5   	     � Title$  Gestion d'un Cinema��5   	   $	��768��6%   $
��1024��65    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�6   $	��768��64   $
��1024��6A      Windows#��[  6N    � 	Resources 5
        GestionCinemaLib.LesFilms  	ListeFilm(   "GestionCinema.AgeToStringConverter  ageConverter(   "GestionCinema._3DToStringConverter  threeDConverter+   %GestionCinema.StringToBitmapConverter  imageConverter,   &GestionCinema.NbPlaceToStringConverter  placeConverter)   #GestionCinema.EuroToStringConverter  euroConverter  	InfoFilms � ColumnDefinitions �� 	Converter  	StyleText 	 infosSeance ��Name 
 StyleTextListBox$ �� IsSynchronizedWithCurrentItem �� ElementName	 �� Path��%  &	       &	      &	 &     &	 9     &	 L     &	 _     &	 r     7  7  7  7  7  7  7  7  &		     7 
 7  7  7  7  7    5   
   6     5   
   6%     5   
   6%     5   
   6(     5   
   6)     5   
   6&   �� 5   
   .R�5      � $
��40,0q�6    5      �� 5      $��1* �6'   �� 5      $��1* �6'   �� 5      $��3* �6'   .+�5      �� $��0��6   $	��170��6l   ��6(   �� *Chemin+8   6l   �� 5      $��1��6   $��Center=�6.   .+�5       �� 8�� $��WrapWithOverflow=�6`   ��6    �� *Realisateur+6`   �� 5"      8�� ��6    �� *Duree+67   �� 5$      8�� $��WrapWithOverflow=�6�   ��6    �� *	AgeLimite+8  6�   �� 5&      8�� ��6    �� *TroisDimension+8  6k   5'      �� 5)      $��2��6   8�� $
��Wrap=�6i   $��Center=�6}   ��6,   �� *
Synopsis+6}   5*      5+      �� 5.   
   .R�5/      �  50      �� 51      $��1* �6'   �� 52      $��2* �6'   .+�55      �� $ seances��6   -   5        $��0��55   +   8��  $
 TrueY�6�   
������ 
������ ��6;   �� *
LesSeances+6�   �� 56      $��1��6   $��Center=�6-   .+�58      �� 8�� $��40(�6�   $��0,0,0,20q�6�   ��6    �� $ seances��$	 SelectedItem.LaSalle�6�   �� 5:      8�� ��6    �� $ seances��$	 SelectedItem.PlaceLibre�8  6�   �� 5<      8�� $��0,6,0,0q�6�   ��6    �� $ seances��$	 SelectedItem.Prix�8  6�   5=      5>      5?      5B      .��5E      ]� .+�5G   
   �� $	��Top=�6   #��[ 6)   $��Billetterie��6L   $��70(�6_   $��
Cordia New)�6m   $��	Underline{�6�   $��0q�6�   �� 5H   
   $	��Top=�6   .+�5J      �� -   5        $��ListeDeFilm��5J      #��[
 6d   $
 TrueY�6�   $��90��6�   $��	10,2,10,0q�6�   
������ $��0q�6�   ��6*   �� 
 �� Source#
 [ ��5K      �� 5L      .R�5M      ��  �� Orientation$ 
Horizontal=�6%   5N      ��5P      �� 5Q       �� 
TargetType" ��6   .�5R      ��  �� Property � �� �� Value$ 	25 0 25 0q�64   5S      5U      �� 5X      #��[ 6S   ��6   �� #
 [ 6S   �� 5[      $	��Top=�6   $��
20,25,20,0q�63   #��[	 6}   ��6G   �� #
 [ 6}   5]      � 5_   
   $��Bottom=�6   $��Bottom=�6'   $��60��6B   ���	#FFA4A4A4 5`      �� 5a      $��1* �6#   �� 5b      $��1* �6#   �� 5c      $��8* �6#   .+�5e      �� -   5        $��0��5e      $��Quitter��6%    
 Footer#��[ 67   6W   �� 5f      -   5        $��1��5f      $��Admin��6%   #��[ 65   6U   �� 5g      -   5        $��Paiement��5g   W   $��2��6   $��Paiment��6%   #��[ 67   6g   5h      � 5k   
   $��Bottom=�6   $��Bottom=�6,   $��Right=�6G   $��	0,0,20,20q�6c   .+�5l      �� -   5        $��<��5l        BoutonInfSup#��[ 6$   6J   �� 5m      -   5        $��TextBlockNbBillet��5m      $��50��6K    �� TextAlignment$ Center=�6V   $��Center=�6m   $��16(�6�   ���	#FFE8E8E8��61   �� *
nbBillet+6�   �� 5n      -   5        $��>��5n      #��[ 6$   6J   5o      5q      5r      