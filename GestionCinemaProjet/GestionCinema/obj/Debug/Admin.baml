   M S B A M L   `   `   `  ����H  DGestionCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestionCinemaGestionCinema  5   	       GestionCinema.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -localclr-namespace:GestionCinema     5   	     � Title$  Admin��5   	   $	��768��6   $
��1024��6$    � WindowStyle$
 none=�61    � WindowState$ 	Maximized=�6E      Windows#��[  5   	    � 	Resources 5      (   "GestionCinema.AgeToStringConverter  ageConverter+   %GestionCinema.StringToBitmapConverter  imageConverter(   "GestionCinema._3DToStringConverter  threeDConverter  _adminInfosSeance �� CornerRadius �� Padding �� EndPoint � MappingMode �� 
StartPoint	 � Color
 � Offset&   System.Windows.Controls.DataGrid  StyleTextDataGrid   ColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value  	InfoFilms � ColumnDefinitions �� 	Converter  	StyleText��%;  &	       &	      &	 &     &	 9     7  &	 C    7  7  7  7  7  7  7  7    5
   
   6%     5   
   6(     5   
   6%   �� 5   
   .R�5      �� ���	#FF626C6C$��2q�6-   $ 20��6A   $��Center=�6S   $ 15q�6p   ��5      �� 5      $ 0.5,1&�6*   $ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5      � $	 	#FFDAFAFD��6'   $
 0Q�69   � 5      $	 	#003E4042��6'   $
 0.203Q�69   5      ._�5        8��  ��6   �� *
LesSeances+ 5      �� 5      "  6    .�5      ��  � ��
 ���� 6;   �� 5       � ��$ 
25,0,25,10q�67   5      5       5!      5"      �� 5%   
   .R�5&      � $
��40,0q�6    5'      �� 5(      $��1* �6'   �� 5)      $��1* �6'   �� 5*      $��3* �6'   .+�5-      �� $��0��6   $	��200��6l   ��6(   �� *Chemin+8   6l   �� 5.      $��1��6   $��Center=�6.   .+�50      �� 8�� $��WrapWithOverflow=�6`   ��6    �� *Realisateur+6`   �� 52      8�� ��6    �� *Duree+67   �� 54      8�� $��WrapWithOverflow=�6�   ��6    �� *	AgeLimite+8  6�   �� 56      8�� ��6    �� *TroisDimension+8  6k   57      �� 59      $��2��6   8�� $
��Wrap=�6i   $��Center=�6}   ��6,   �� *
Synopsis+6}   5:      5;      5>      .��5@      ]� .+�5B   
   o� $	��top=�6   $��30��6$   $��16(�60   .@�5C      m� -   5        $��Ajouter Film��5C      6-   m� 5D      -   5        $��Ajouter Seance��5D      6/   m� 5E      -   5        $��Ajouter Projectionniste��5E      68   m� 5F      -   5        $��Ajouter Salle��5F      6.   m� 5G      -   5        $��Supprimer Film��5G      6/   m� 5H      -   5        $��Supprimer Seance��5H      61   m� 5I      -   5        $��Supprimer Projectionniste��5I      6:   m� 5J      -   5        $��Supprimer Salle��5J      60   m� 5K      -	   5        $��Nouveau Programme��5K      62   5L      �� 5O   
   -
   5        $��ListeDeFilm��5O   '   $	��Top=�6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6:    �� SelectedIndex$ 0��6_   $��90��6q   $��
10,10,10,0q�6~   
������ $��0q�6�   ���	#FFE8E8E8$��20(�6�   $��Center=�6�   ��5P      �� 5Q      .R�5R      ��  �� Orientation$ 
Horizontal=�6%   5S      ��5U      �� 5V      " ��6   .�5W      ��  � ��$ 	25 0 25 0q�64   5X      5Z      �� 5]   
   $	��Top=�6   #��[ 6l   ��6.   ��  �� ElementName$ ListeDeFilm�� �� Path$ SelectedItem�6l   �� 5`   
   $	��Top=�6   #��[ 6l   ��6.   �� $ ListeDeFilm��$ SelectedItem�6l   �� 5c   
   $��Bottom=�6   $��Bottom=�6-   $��60��6H   ���	#FFA4A4A4.+�5d      �� -   5        $��Center=�5d      $��Quitter Administrateur��62    
 Footer#��[ 6S   $
��30,5q�6s   6�   5e      5g      5h      