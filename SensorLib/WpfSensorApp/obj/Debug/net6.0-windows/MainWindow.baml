   M S B A M L   `   `   `  ����  WpfSensorApp    WpfSensorApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$&   Greenhouse Sensoring Application��5   	   $	��600��5   	   $
��1000��6   $��Segoe UI)�5	   	   $��14(�5
   	   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 0,1&�6/   .��5      �  � Color$ LightSkyBlue��6    � Offset$ 0Q�60   � 5      $ White��6   $ 1Q�6)   5      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   �� $8��2🌿 Smart Greenhouse Dashboard – Monitor & Grow��6   $
��Bold"�5      $��14(�5      ���#0a3958���	#99FFFFFF���#00BFFF$��2q�5      $��5q�5       $��5q�5!      .��5"      � .+�5#      &   System.Windows.Controls.DataGrid  -   5          Name$ SensorDataGrid��5#         AutoGenerateColumns$ False��63   $��10q�6O      HeadersVisibility$ Column=�5$      	   CanUserAddRows$	 False��66   
   
IsReadOnly$

 True��6M   ���#FDFEFF���#003366   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Name+6T     5(      $ Location��6-   $ * 6\    6?   �� *
Location+6\     5)      $
 Type��6-   $ * 6T    6;   �� *Type+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5*      $ Action��61   $	 100 6A      CellTemplate 5+      �� 5,   "   .R�5-   &   ��  �� Orientation$ 
Horizontal=�61   $��Center=�6J   .+�5.   *   �� -   5        $��✏️��5.   1    � ToolTip$ Bewerk sensor��5/   1   $��16(�50   1   
���   �$��2q�53   1   $��0q�54   1   
������ 55   1   �� 56   *   -   5        $��🗑️��56   1   $ Verwijder sensor��57   1   $��16(�58   1   
���  ��$��2q�5;   1   $��0q�5<   1   
������ 5=   1   5>   '   5?   #   5A      5C      5D      5E      �� 5H   
   $&�� ✨ Sensor toevoegen of bewerken��6   $��1��5I      ���	#99FFFFFF���#00BFFF$��2q�5L      $
��Bold"�5M      $��14(�5N      ���#0a3958$��5q�5P      $��10q�5Q      .��5R      �� $��5q�6   .+�5S      �� $��🌐 Sensor type:��6   �� 5T      -   5         ��Name$ SensorTypeComboBox��5T      $��0,0,0,10q�67   
�������.@�5W      �� $��LevelSensor��6#   �� 5X      $��MoistureSensor��6#   �� 5Y      $��TempHumiSensor��6#   �� 5Z      $��UVSensor��6#   5[      �� 5]      $��
📝 Naam:��6   �� 5^      -   5         ��Name$ NameTextBox��5^      $��0,0,0,10q�6/   
�������6A   �� 5`      $��📍 Locatie:��6   �� 5a      -   5        $ LocationTextBox��5a      $��0,0,0,10q�63   
�������6E   �� 5d      -   5         ��Name$ SensorDetailsPanel��5d      �� 5g      -   5         ��Name$ 	AddButton��5g      $��➕ Add Sensor��5h      $��
10,20,10,0q�5i      $	��8,4q�5j      $��16(�5k      $
��Bold"�5l      ���#00BFFF
�������$��0q�5o       � Cursor$
 Hand��5p      5q      5r      5s      5t      5u      