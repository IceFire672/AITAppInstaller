import { IonButton, IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import './Home.css';
import { useEffect, useState } from 'react';

const Home: React.FC = () => {
  const [dt, setDt] = useState('');

  const fetchFromApi = async () => {
    const res = await fetch('/api/test');
    const data = await res.text();
    setDt(data);
  };

  useEffect(() => {
    fetchFromApi();
  }, []);

  return (
    <IonPage>
      <IonHeader>
        <IonToolbar>
          <IonTitle>Blank</IonTitle>
        </IonToolbar>
      </IonHeader>
      <IonContent fullscreen>
        <IonTitle size="large">DateTime: {dt}</IonTitle>
        <IonButton onClick={() => fetchFromApi()}>Click Me!</IonButton>
      </IonContent>
    </IonPage>
  );
};

export default Home;
