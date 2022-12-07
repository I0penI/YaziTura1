namespace YaziTura1.Classes
{
    /// <summary>
    /// Yazı Tura için kullanılacak Para sınıfı;
    /// </summary>
    class Para
    {
        bool _yaziMi;
        Random _random = new Random();
        /// <summary>
        /// Bu method random tipinde bir obje üzeriden yazı için true, tura için false sonucu döner.
        /// </summary>
        /// <returns>bool</returns>
        public bool At()
        {
            int randomSayi = _random.Next(0, 2);
            _yaziMi = false;
            if (randomSayi == 1)  // 1: yazı 0: tura
                _yaziMi = true;
            return _yaziMi;

            
        }
    }
}
