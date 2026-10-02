import {
  Table,
  TableBody,
  TableCaption,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table";

function Operations() {
  return (
    <div>
      <div className="border rounded-lg p-6">
        <Table>
          <TableHeader>
            <TableRow>
              <TableHead className="w-[150px]">Date</TableHead>
              <TableHead className="w-[100px]">Time</TableHead>
              <TableHead className="w-[150px]">Category</TableHead>
              <TableHead>Label</TableHead>
              <TableHead className="text-right">Amount</TableHead>
            </TableRow>
          </TableHeader>
          <TableBody>
            <TableRow>
              <TableCell className="font-medium">05/09/2026</TableCell>
              <TableCell>10:30 AM</TableCell>
              <TableCell>Transport</TableCell>
              <TableCell>Grab</TableCell>
              <TableCell className="text-right">$14.00</TableCell>
            </TableRow>
          </TableBody>
        </Table>
      </div>
    </div>
  );
}

export default Operations;
