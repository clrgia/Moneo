function Overview() {
  return (
    <>
      <p className="font-bold ">Overview</p>
      <div className="flex gap-4 justify-between border rounded-lg p-6">
        <div>
          <p className="text-sm font-medium opacity-70">Balance</p>
          <p className="text-[40px] font-black text-[#66CC8A]">12 000$</p>
        </div>
        <div>
          <p className="text-sm font-medium opacity-70">Expenses</p>
          <p className="text-[40px] font-black text-[#F68067]">5 000$</p>
        </div>
        <div>
          <p className="text-sm font-medium opacity-70">Income</p>
          <p className="text-[40px] font-black text-[#377CFB]">7 000$</p>
        </div>
      </div>
    </>
  );
}

export default Overview;
