import './style.css';
import Overview from "./components/Overview.tsx";
import Operations from './components/Operations.tsx';
import { Chart } from './components/Chart.tsx';

function App() {

  return (
    <div className="flex flex-col gap-4 px-42 pt-4">
      <Overview />
      <p className="font-bold ">Operations</p>
      <div className="grid grid-cols-[2fr_1fr] gap-4 border rounded-lg p-4">
        <Operations />
        <Chart />
      </div>
    </div>
  );
}

export default App
