   M S B A M L   `   `   `  ����G  CcaesarCipher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:caesarCiphercaesarCipher  5   	       caesarCipher.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:caesarCipher     5   	     � Title$  
MainWindow��5   	   $��403.431��6   $��526.709��6-   .��5	      � $��0,0,2,7q�6   .+�5
   
   �� -   5         ��Name$ Title1��5
      $
��Left=�6$   $
��Wrap=�6?   $	��Top=�6S   $��27��6k   $	��311��6w   $��	10,10,0,0q�6�   $.��(Caesar Cipher- Wyatt Hite, Trevor Waters��6�   $
��Bold"�6�   $��Vrinda)�6�   $��14(�6  ��6�   Z� 6  �� 5   
   -   5         ��Name$ enterButton1��5      $	��Go!��6'   $	��Top=�65   $��380,144,21,0q�6M   $��39��6c    �� IsCancel . 6   	� 5   
   -   5         	�Name$ Encrypt1��5      $��Encrypt��6(   $
��Left=�6:   $��304,144,0,0q�6U   $	��Top=�6j    d� 	IsChecked$
 TrueY�6�   	� 5   
   -   5        $ decrypt1��5      $��Decrypt��6(   $
��Left=�6:   $��303,161,0,0q�6U   $	��Top=�6j   6�   �� 5   
   -   5         ��Name$ userText��5      $
��Left=�6$   $��46��6?   $��	10,93,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $��enter text...��6r   $	��Top=�6�   $	��485��6�    �� 	MaxLength$	 200��6�   6�   �� 5   
   $
��Left=�6   $��	10,37,0,0q�6/   $
��Wrap=�6B   $c��]Welcome to the Caesar Cipher Solver. Please enter text you wish to encrypt or decrypt below. ��6V   $	��Top=�6�   	 � Cursor$	  ��6�   �� 5   
   -   5        $ encryptionKey��5      $
��Left=�6)   $��28��6D   $��148,144,0,0q�6P   $
 Wrap=�6e   $��key...��6y   $	��Top=�6�   $��52��6�   
 �� TextAlignment$
 Center=�6�   �� 5   
   $
��Left=�6   $��38��6/   $��
10,144,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��138��6{   �� 6�   $3�-Please enter a numerical encryption key here:��6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $ 	outputTag��5      $
��Left=�6'   $��
10,201,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   $��16��6�   $��41��6�   �� 6�   $�Output:��6�   �� 6�   �� 6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $ 	outputBox��5      $
��Left=�6'   $��
10,231,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   $	��485��6�   $��76��6�   �� 6�   $8�2(default; enter text above to encrypt or decrypt.)��6�   6�   �� 5   
   $
��Left=�6   $��4��62   $��
17,222,0,0q�6=   $	��Top=�6Q   $	��456��6i   �� 5   
   $
��Left=�6   $��38��6/   $��222,144,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��76��6|   �� 6�   $�Please select��6�   �� 6�   �� 6�   $�a mode:��6�   6�   �� 5   
   -	   5        $ inputTag��5      $
��Left=�6&   $��	10,63,0,0q�6A   $
��Wrap=�6T   $	��Top=�6h   $��16��6�   $��41��6�   $��Input:��6�   �� 5   
   $
��Left=�6   $��4��62   $��	17,84,0,0q�6=   $	��Top=�6P   $	��456��6h   �� 5   
   -
   5        $ clipboardOutput��5      $��Copy output to clipboard��6*   $
��Left=�6M   $	��Top=�6h   $	��143��6�   $��353,312,0,0q�6�   6�   5      5      