   M S B A M L   `   `   `  ���� H  DGestionCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestionCinemaGestionCinema  K GGestionCinemaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLibGestionCinemaLib O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem     GestionCinema.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:GestionCinema     Gmy8clr-namespace:GestionCinemaLib;assembly=GestionCinemaLib     9System&clr-namespace:System;assembly=mscorlib       � Title$  Gestion d'un Cinema��$	��768��$
��1024�� � WindowStyle$
 none=� � WindowState$ 	Maximized=�   Windows#��[   � 	Resources (   "GestionCinema.AgeToStringConverter  ageConverter(   "GestionCinema._3DToStringConverter  threeDConverter+   %GestionCinema.StringToBitmapConverter  imageConverter,   &GestionCinema.NbPlaceToStringConverter  placeConverter)   #GestionCinema.EuroToStringConverter  euroConverter 
 footer �� 
TargetType �� Property �� Value  BoutonInfSup  	InfosFilm  GestionCinemaLib.LesFilms 	 	ListeFilm 
 	InfoFilms � ColumnDefinitions �� 	Converter  _infosSeance	 ��Name$
 �� IsSynchronizedWithCurrentItem �� ElementName �� Path  _adminInfosSeance&   System.Windows.Controls.DataGrid   
IsReadOnly   RowBackground   CanUserAddRows   CanUserReorderColumns   CanUserDeleteRows)   #GestionCinema.AdminTemplateSelector  DataTempateAdminSelecte   ChildTemplate   AdultTemplate��%�  &	       &	      &	 
     &	      &	      &	      &	 �     &	 �     &		 6    &	
 ;    7  7  7  7  7  7  7  7  &	 �    7  7  &	 �    &	 #    7  7            �� " ��.���  � ��$ 20(���  � ��$
 Bold"���  � ��$ BrowalliaUPC)���  � ��$
 4,10q��� " ��.���  � ��$ 10q���  � ��$ 30(���  � ��$ 40���� " ��.���  � �� �	#FFE8E8E8��  � ��$ 20(���  � ��$ Center=�  �� .R�� $
��40,0q� �� $��2* ��� $��1* ��� $��4* �.+��� $��0��$	��200������ *Chemin+8   �� $��1��$��Center=�.+��� 8�� ���� *Realisateur+�� 8�� ���� *Duree+�� 8�� ���� *	AgeLimite+8  �� 8�� ���� *ThreeDimension+8  �� $��2��8�� $
��Wrap=�$��Center=����� *
Synopsis+�� .R��  �� $��1* ��� $��2* �.+��� $	 seances��-   $��0��$

 TrueY�
������ 
������ $��30(����	#FFE8E8E8$��Center=����� *
LesSeances+�� $��1��$��Center=�.+��� ���	#FFE8E8E8$��40(�$��0,0,0,20q�$��Center=����� $ seances��$ SelectedItem.LaSalle��� ���	#FFE8E8E8$��25(�$��Center=����� $ seances��$ SelectedItem.PlaceLibre�8   �� ���	#FFE8E8E8$��25(�$��Center=�$��0,6,0,0q����� $ seances��$ SelectedItem.Prix�8  �� .R�   . 
 �   � .   .   .  $��30(����	#FFE8E8E8$��Center=����� *
LesSeances+  8   8  .��]� .+��� $	��Top=�$��Billetterie��$��Center=�$��70(����	#FFE8E8E8$��
Cordia New)�$��	Underline{��� $	��Top=�.+��� -   $��ListeDeFilm��$

 TrueY�$��90��$��
10,10,10,0q�
������ $��0q����	#FFE8E8E8$��20(�$��Center=�����  �� Source# [	 ���� .R���  �� Orientation$ 
Horizontal=����� " ��.���  � ��$ 	25 0 25 0q��� #��[
 ���� # [	 �� -   $��Selector��$	��Top=�$��
20,25,20,0q�#��[ ���� # [	 � $��Bottom=�$��Bottom=�$��60�����	#FFA4A4A4 �� $��1* ��� $��1* ��� $��8* �.+��� -   $��0��$��Quitter��#��[ �� -   $��1��$��Admin��#��[ �� -   $��Paiement��$��2��$��Paiment��#��[ � $��Bottom=�$��Bottom=�$��Right=�$��	0,0,20,20q�.+��� -   $��-��#��[ �� -   $��TextBlockNbBillet��$��50�� �� TextAlignment$ Center=�$��Center=�$��16(����	#FFE8E8E8���� *
nbBillet+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL��� -	   $��+��#��[ 