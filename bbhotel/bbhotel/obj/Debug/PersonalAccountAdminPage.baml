   M S B A M L   `   `   `  ????B  >bbhotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:bbhotelbbhotel  5      &     bbhotel.PersonalAccountAdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:bbhotel     5      -   5          N? Title$  PersonalAccountAdminPage??5	      .??5      ? 
??????  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      ?? 5      $??68 ?6   .+?5   
   ? $??0??6   .+?5      ?? $??ADMIN??6   $??30(?6%   $
??Bold"?63   $??Center=?6E   $
??Left=?6`   ???#c973006{   ?? 5      -   5        $??userInfo??5   %   $??. . .??6   $??Center=?65   $??Right=?6P   
???   ?$??24(?6   $??0, 0, 20, 0q?6?   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
RoomsHotel??5       $??1??6      AutoGenerateColumns .     
IsReadOnly .    RowHeaderWidth$ 0Q?6b      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   ?? *name+6P     5      $# Количество мест??6%   $	 110 6[   	 6>   ?? *
quantity+6[     5      $ Цена/сутки??6%   $ 77 6R   	 69   ?? *cost+6R   4  .System.Windows.Controls.DataGridTemplateColumn  5      $  Редактировать??6)   $ * 6@   
   CellTemplate
 5      ?? 5      .R?5      ?? $??btnEdit??6%    ? Cursor$
 Hand??64   ??5   "   ?? 5   &   .R?5    *   ? .+?5!   .   ??  ?? RadiusX$ 10??68    ?? RadiusY$ 10??6E   $??2??6R   ???#fc9f1d6y   ?? 5"   .   $ ??Редактировать??68   $??13(?6M   $??Center=?6[   $??Center=?6x   ???#fc9f1d6?   5#   +   5$   '   5&      5'      5)      5+      ? 5,   
   $??2??6   .+?5-      ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?62   .+?5.      ?? -   5        $??btnAdd??5.   ?   $??Right=?6   $	??100??65   $??30??6A   $??20, 0, 20, 0q?6M   $
 Hand??6c   ??5/      ?? 50      .R?51      ? .+?52   "   ?? $ 10??6,   $ 10??69   $??3??6F   ???#fc9f1d6m   ?? 53   "   $??Добавить??6,   $??20(?6<   $??Center=?6J   $??Center=?6g   ???#fc9f1d6?   54      55      57      ?? 58      -   5        $??	btnDelete??58   ?   $
??Left=?6   $	??100??64   $??30??6@   $??20, 0, 20, 0q?6L   $
 Hand??6b   ??59      ?? 5:      .R?5;      ? .+?5<   "   ?? $ 10??6,   $ 10??69   $??3??6F   ???#fc9f1d6m   ?? 5=   "   $??Удалить??6,   $??20(?6;   $??Center=?6I   $??Center=?6f   ???#fc9f1d6?   5>      5?      5A      5B      ?? 5C      -   5        $??Right=?5C      $??90??61   $??30??6<   $??0, 0, 25, 0q?6H   $
 Hand??6]   ??5D      ?? 5E      .R?5F      ? .+?5G      ?? $ 10??6(   $ 10??65   $??3??6B   ???#fc9f1d6i   ?? 5H      $??
Выход??6(   $??20(?65   $??Center=?6C   $??Center=?6`   ???#fc9f1d6{   5I      5J      5L      5M      5N      5O      